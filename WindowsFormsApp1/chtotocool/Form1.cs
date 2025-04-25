using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chtotocool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я делаю так как вы сказали это круто так делать спасибо что я трачу на это сваю жизнь", "СПАСИЬБО СПАСБАПИО СААПСИБО");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= бд Вишняков.mdb";
            OleDbConnection cmd = new OleDbConnection(connectionString);

            cmd.Open();
            string query = "SELECT * FROM Сотрудники";
            OleDbCommand cmd2 = new OleDbCommand(query, cmd);
            OleDbDataReader reader = cmd2.ExecuteReader();

            if (reader.HasRows == false)
            {
                MessageBox.Show("ЕЕЕ ОН ВИДИТ ЧТО-ТО НО ОН ЭТО НЕ ДЕЛАЕТ", "АШАЛЕТЬ");
            }
            else
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["ID_сотрудники"], reader["ФИО_сотрудника"], reader["Должность"], reader["Зарплата"]);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("АДНА СТРАКА НАДА", "ALERT!!!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не все данные введены", "ALERT!!!");
                return;
            }

            string ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string FIO = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string STATUS = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string SALARY = dataGridView1.Rows[index].Cells[3].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= бд Вишняков.mdb";
            OleDbConnection cmd = new OleDbConnection(connectionString);

            cmd.Open();
            string query = "INSERT INTO Сотрудники VALUES (" + ID + ", '" + FIO + "', " + STATUS + ", " + SALARY + ")";
            OleDbCommand cmd2 = new OleDbCommand(query, cmd);

            if (cmd2.ExecuteNonQuery() != 1)
                MessageBox.Show("OSHIBKA!!!", "ALERT!!!");
            else
                MessageBox.Show("DATA ADDED", "ALERT!!!");

            cmd.Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if (dataGridView1.SelectedRows.Count != 1)
            //{
            //    MessageBox.Show("АДНА СТРАКА НАДА", "ALERT!!!");
            //    return;
            //}
            //int index = dataGridView1.SelectedRows[0].Index;

            //if (dataGridView1.Rows[index].Cells[0].Value == null ||
            //    dataGridView1.Rows[index].Cells[1].Value == null ||
            //    dataGridView1.Rows[index].Cells[2].Value == null ||
            //    dataGridView1.Rows[index].Cells[3].Value == null)
            //{
            //    MessageBox.Show("Не все данные введены", "ALERT!!!");
            //    return;
            //}

            //string ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //string FIO = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //string STATUS = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //string SALARY = dataGridView1.Rows[index].Cells[0].Value.ToString();

            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= бд Вишняков.mdb";
            //OleDbConnection cmd = new OleDbConnection(connectionString);

            //cmd.Open();
            //string query = 
            //OleDbCommand cmd2 = new OleDbCommand(query, cmd);

            //if (cmd2.ExecuteNonQuery() != 1)
            //    MessageBox.Show("OSHIBKA!!!", "ALERT!!!");
            //else
            //    MessageBox.Show("DATA ADDED", "ALERT!!!");

            //cmd.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("АДНА СТРАКА НАДА", "ALERT!!!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не все данные введены", "ALERT!!!");
                return;
            }

            string ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
        
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= бд Вишняков.mdb";
            OleDbConnection cmd = new OleDbConnection(connectionString);

            cmd.Open();
            string query = "DELETE FROM Сотрудники WHERE ID_Сотрудника = " + ID;
            OleDbCommand cmd2 = new OleDbCommand(query, cmd);

            if (cmd2.ExecuteNonQuery() != 1)
                MessageBox.Show("OSHIBKA!!!", "ALERT!!!");
            else
                MessageBox.Show("DATA DELETED", "ALERT!!!");
                dataGridView1.Rows.RemoveAt(index);

            cmd.Close();
        }
    }
}
