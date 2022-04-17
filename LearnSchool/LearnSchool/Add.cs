using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearnSchool
{
    public partial class Add : Form
    {
        private MSSconnection DB = new MSSconnection();
        private int clientId, serviceId;
        private int year, mounth, day, hours, minutes;
        private bool clientExists;
        DateTime date;

        public Add()
        {
            InitializeComponent();
        }

        //обновление формы.
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.schoolDataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.schoolDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.schoolDataSet.Service);

        }

        private void lessonEndCalc_Click(object sender, EventArgs e)
        {
            int starth = Convert.ToInt32(textBox1.Text);
            int startm = Convert.ToInt32(textBox4.Text);
            int seconds = Convert.ToInt32(textBox2.Text);

            //преобразовать время в секунды
            timeInSeconds time = new timeInSeconds();
            int[] fields = new int[3] {
                starth, startm, 0
            };

            //добавить секунды (продолжительность для подсчета)
            time.AddTime(fields);
            time.AddSeconds(seconds);
            int[] formTime = time.GetFullTime();

            textBox3.Text = formTime[0].ToString();
            textBox5.Text = formTime[1].ToString();
        }

        //Ввод только целых чисел и символа стирания.
        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char _char = e.KeyChar;
            if (!Char.IsDigit(_char) && !Char.IsControl(_char)) {
                e.Handled = true;
            }
        }

        //Приминение изменений к записи клиента
        private void addStudent_Click(object sender, EventArgs e)
        {
            if (hours >= 24 || minutes >= 60) return;
            string startDate = dateTimePicker1.Value.ToString().Split(' ')[0];
            string sql = $"UPDATE [dbo].[ClientService] SET [ServiceID] = {serviceId}, [StartTime] = '{startDate} {hours}:{minutes}:00' WHERE [ClientID] = {clientId}";
            SqlCommand command = new SqlCommand(sql, DB.getConnection());
            DB.openConnection();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменения были успешно применены.", "Успех");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Не удалось приминить изменения.\n{exp.Message}", "Ошибка");
            }
            finally {
                DB.closeConnection();
                this.Close();
                Add form = new Add();
                form.Show();
            }
        }

        //Автозаполнение поля продолжительность из таблицы услуг
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "") return;

            serviceId = comboBox2.SelectedIndex + 1;
            string sql = $"SELECT [DurationInSeconds] FROM [dbo].[Service] WHERE ID = {serviceId}";

            DataTable table = DB.ExecuteSqlCommand(sql);
            textBox2.Text = table.Rows[0][0].ToString();

            checkFields();
        }

        private void timeBoxes_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) >= 24) {
                MessageBox.Show("Начало урока не может привышать 23:59.", "Ошибка ввода");
                textBox1.Text = "23";
                hours = 23;
            }

            if (Convert.ToInt32(textBox4.Text) >= 60)
            {
                MessageBox.Show("Начала минут урока не может привышать знаение 59.", "Ошибка ввода");
                textBox4.Text = "59";
                minutes = 59;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            checkFields();
        }
        

        //Получения информации о записи клиента
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "") return;

            clientId = comboBox1.SelectedIndex + 1;
            string sql = $"SELECT [StartTime] from [dbo].[ClientService] WHERE [ClientID] = {clientId}";
            string sql2 = $"SELECT TOP(1) [Title] from [dbo].[ClientService] join [dbo].[Service] on [Service].[ID] = [ClientService].[ServiceID] where[ClientService].[ClientID] = {clientId};";
            string timeStoke, dateStroke;
            string[] time;
            DataTable cv_time = DB.ExecuteSqlCommand(sql);
            DataTable serviceTableNameOld = DB.ExecuteSqlCommand(sql2);
            if (serviceTableNameOld.Rows.Count == 0) {
                textBox6.Text = "Клиент никуда не записан";
                clientExists = false;
                checkFields();
                return;
            }

            clientExists = true;
            DataRow serviceRowOldName = serviceTableNameOld.Rows[0];

            textBox6.Text = serviceRowOldName[0].ToString();
            timeStoke = cv_time.Rows[0][0].ToString().Split(' ')[1];
            dateStroke = cv_time.Rows[0][0].ToString().Split(' ')[0];
            time = timeStoke.Split(':');
            textBox1.Text = time[0];
            textBox4.Text = time[1];
            hours = Convert.ToInt32(time[0]);
            minutes = Convert.ToInt32(time[1]);
            day = Convert.ToInt32(dateStroke.Split('.')[0]);
            mounth = Convert.ToInt32(dateStroke.Split('.')[1]);
            year = Convert.ToInt32(dateStroke.Split('.')[2]);
            date = new DateTime(year, mounth, day);
            dateTimePicker1.Value = date;
            checkFields();
        }

        //Проверка, что поля и запись для изменения существуют.
        private void checkFields() {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox4.Text.Length == 0 || !clientExists)
            {
                lessonEndCalc.Enabled = addStudent.Enabled = false;
            }
            else
            {
                lessonEndCalc.Enabled = addStudent.Enabled = true;
                hours = Convert.ToInt32(textBox1.Text);
                minutes = Convert.ToInt32(textBox4.Text);
            }
        }
    }
}
