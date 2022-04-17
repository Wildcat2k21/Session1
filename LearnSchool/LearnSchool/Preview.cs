using System;
using System.Windows.Forms;

namespace LearnSchool
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet3.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.schoolDataSet3.ClientService);

        }
    }
}
