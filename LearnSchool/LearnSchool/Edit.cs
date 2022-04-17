using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearnSchool
{
    public partial class Edit : Form
    {
        //данные для изменения
        private MSSconnection DB;
        private DataTable table;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataRow dataRow;

        public Edit()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet5.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.schoolDataSet5.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet4.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.schoolDataSet4.Service);
            DB = new MSSconnection();
            DB.openConnection();
            updateForm();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DB == null) return;
            updateForm();
        }

        //Обновление данных в таблица сервис
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlText = $"update [dbo].[service] set [Title] = '{nameText.Text}', [Cost] = {stoimostText.Text.Replace(',','.')}, [DurationInSeconds] = {dlitelnostText.Text}, [Description] = '{opisanieText.Text}', [Discount] = {skidkaText.Text} where [Title] = '{comboBox2.Text}'";
            SqlCommand sql = new SqlCommand(sqlText, DB.getConnection());
            try
            {
                sql.ExecuteNonQuery();
                MessageBox.Show("Поля успешно сохранены", "Успех");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Не удалось сохранить изменения. \n Вероятнее всего вы ввели в поля для цифр текст. \n Использовали запятую вместо точки, чтобы обозначить десятичную часть. \n Использовали нецелые числа в полях (Продолжительность). \n Измените поля и повторите попытку. \n\n {exp.Message}", "Ошибка");
            }
            finally {
                this.Close();
                Edit form1 = new Edit();
                form1.Show();
            }
        }

        //Получение полей из таблицы сервиса и присвония полям формы
        private void updateForm() {
            if (comboBox2.Text == "") return;
            string sqlText = $"SELECT * from [dbo].[service] where [Title] = '{comboBox2.Text}'";
            SqlCommand sql = new SqlCommand(sqlText, DB.getConnection());
            adapter.SelectCommand = sql;
            table = new DataTable();
            adapter.Fill(table);
            dataRow = table.Rows[0];

            //присваивание данных полях из бд
            nameText.Text = dataRow[1].ToString();
            stoimostText.Text = dataRow[2].ToString();
            dlitelnostText.Text = dataRow[3].ToString();
            opisanieText.Text = dataRow[4].ToString();
            skidkaText.Text = dataRow[5].ToString();
            kartinkaUslugi.Image = new Bitmap(@"images\" + dataRow[6].ToString());
        }
    }
}
