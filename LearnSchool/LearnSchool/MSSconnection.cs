using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LearnSchool
{
    class MSSconnection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MSSconnection"].ConnectionString;
        private SqlConnection connection = new SqlConnection(connectionString);

        //открыть подключение
        public void openConnection() {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
        }

        //закрыть подключение
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection() {
            return connection;
        }

        //Выполнение коман sql
        public DataTable ExecuteSqlCommand(string sql)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
