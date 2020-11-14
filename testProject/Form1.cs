using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace testProject
{ 
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=WIN-VRBPB50JC4A; Database = Saloon;User ID=ws04;Password=123qweR%";
        public Form1()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string select = "SELECT * FROM Employees";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string select = "SELECT * FROM Products";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string select = "SELECT * FROM Service_xz";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string select = "SELECT * FROM Registration";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string select = "SELECT Employee_Name FROM Employees INNER JOIN Registration ON Employee_Id = Id_Employee WHERE Registration_date = '2020-11-10'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void работникиСашToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string select = "SELECT Employee_Name FROM Employees WHERE Employee_Name Like 'Саш%'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
