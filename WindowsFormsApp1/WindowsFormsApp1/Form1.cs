using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= бд Вишняков.mdb";

        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            
            connection = new OleDbConnection(connectionString);

            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT ФИО_сотрудника FROM Сотрудники WHERE ID_сотрудники = 1";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            textBox1.Text = cmd.ExecuteScalar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT ФИО_сотрудника, Должность, Зарплата FROM Сотрудники ORDER BY ID_сотрудники";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            OleDbDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();


            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            }

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Сотрудники (ФИО_сотрудника, Должность, Зарплата) VALUES ('Маликов Арсений Владимировач', 'Безработный', 0)";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Сотрудники SET Зарплата = 300000 WHERE ID_сотрудники = 6";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Сотрудники WHERE ID_сотрудники < 3";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            cmd.ExecuteNonQuery();
        }
    }
}
