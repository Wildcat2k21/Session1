using System;
using System.Data;
using System.Windows.Forms;

namespace LearnSchool
{
    public partial class MainForm : Form
    {
        MSSconnection DB;
        public MainForm()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit EditForm = new Edit();
            EditForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add StudentForm = new Add();
            StudentForm.Show();
            this.Hide();
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            Preview Info = new Preview();
            Info.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.schoolDataSet.Service);
            AddButton.Enabled =  EditButton.Enabled = PreviewButton.Enabled = false;
            DB = new MSSconnection();
        }

        private void KodButton_Click(object sender, EventArgs e)
        {
            if (KodText.Text != "0000")
            {
                MessageBox.Show("Неверный код", "ошибка");
                AddButton.Enabled = EditButton.Enabled = PreviewButton.Enabled = false;
            } else
                AddButton.Enabled = EditButton.Enabled = PreviewButton.Enabled = true;
        }

        //Приминение фильтра скидки
        private void filtrBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateGridView();
        }

        //обновление содержимого таблицы с учетом фильтров
        private void updateGridView() {
            string filterDiscount, filterSearch;
            switch (filtrBox.Text)
            {
                case "От 0% до 15%":
                    filterDiscount = " WHERE [Discount] >= 0 AND [Discount] <= 15";
                    break;
                case "От 15%  до 30%":
                    filterDiscount = " WHERE [Discount] >= 15 AND [Discount] <= 30";
                    break;
                case "От 30% до 70%":
                    filterDiscount = " WHERE [Discount] >= 30 AND [Discount] <= 70";
                    break;
                case "От 70% до 100%":
                    filterDiscount = " WHERE [Discount] >= 70 AND [Discount] <= 100";
                    break;

                default:
                    filterDiscount = "";
                    break;
            }

            if (filterDiscount.Length != 0)
                filterSearch = $" AND [Title] LIKE '%{searchBox.Text}%'";
            else
                filterSearch = $" WHERE [Title] LIKE '%{searchBox.Text}%'";


            string sql = $"SELECT * FROM [dbo].[Service]{filterDiscount}{filterSearch};";
            DataTable data = DB.ExecuteSqlCommand(sql);
            dataGridService.DataSource = data;
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            updateGridView();
        }
    }
}
