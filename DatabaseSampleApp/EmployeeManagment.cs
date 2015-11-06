using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DatabaseSampleApp
{
    public partial class EmployeeManagment : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;database=dbhassan;port=3306;username=root;password=nasa");
        MySqlCommand mcd;
        public EmployeeManagment()
        {
            InitializeComponent();
            GenderCB.SelectedItem = "Male";
            GenderSearch.SelectedItem = "Male";
            UpdateGender.SelectedItem = "Male";
        }


        public void openSqlConnection()
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
        }
        public void closeSqlConnection()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }


        public void executeQuery(string query)
        {
            try
            {

                openSqlConnection();
                mcd = new MySqlCommand(query, myConn);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    toolStripStatusLabel1.Text = "Query Executed";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Query Not Executed";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
            finally
            {
                closeSqlConnection();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertDataToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query;
                query = "INSERT INTO users (FirstName,LastName,Gender,Address,JobTitle,CNIC)  values('" + FNameTB.Text + "','" + LNameTB.Text + "','" + GenderCB.SelectedItem.ToString() + "','" + AddressTB.Text + "','" + JobTitleTB.Text + "'," + double.Parse(CNICTB.Text) + ")";
                executeQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users", myConn);
                Adapter.Fill(readerDataSet);
                dataGridView1.DataSource = readerDataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                string query;
                query = "UPDATE users SET FirstName='" + UpdateFirstName.Text + "',LastName='" + UpdateLastName.Text + "',Gender='" + UpdateGender.SelectedItem.ToString() + "',Address='" + UpdateAddress.Text + "',JobTitle='" + UpdateJobTitle.Text + "' WHERE CNIC=" + double.Parse(UpdateCNICTB.Text);
                executeQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SearchButtonUpdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where CNIC=" + double.Parse(UpdateCNICTB.Text), myConn);
                Adapter.Fill(readerDataSet);
                UpdateFirstName.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[0];
                UpdateLastName.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[1];
                UpdateGender.SelectedItem = (string)readerDataSet.Tables[0].Rows[0].ItemArray[2];
                UpdateAddress.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[3];
                UpdateJobTitle.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[4];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox3.SelectedItem.ToString() == "FirstName" || comboBox3.SelectedItem.ToString() == "LastName" || comboBox3.SelectedItem.ToString() == "JobTitle")
                {
                    DataSet readerDataSet = new DataSet();
                    MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where " + comboBox3.SelectedItem.ToString()+" = '" +NameSearch.Text+"'", myConn);
                    Adapter.Fill(readerDataSet);
                    dataGridView1.DataSource = readerDataSet.Tables[0];
                }
                if (comboBox3.SelectedItem.ToString() == "CNIC")
                {
                    DataSet readerDataSet = new DataSet();
                    MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where " + comboBox3.SelectedItem.ToString() + " = " + double.Parse(CNICSearch.Text), myConn);
                    Adapter.Fill(readerDataSet);
                    dataGridView1.DataSource = readerDataSet.Tables[0];
                }
                if (comboBox3.SelectedItem.ToString() == "Gender")
                {
                    DataSet readerDataSet = new DataSet();
                    MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where " + comboBox3.SelectedItem.ToString() + " = '" +GenderSearch.SelectedItem.ToString()+"'", myConn);
                    Adapter.Fill(readerDataSet);
                    dataGridView1.DataSource = readerDataSet.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "FirstName" || comboBox3.SelectedItem.ToString() == "LastName" || comboBox3.SelectedItem.ToString() == "JobTitle")
            {
                GenderSearch.Visible = false;
                CNICSearch.Visible = false;
                NameSearch.Visible = true;
                
            }
            if (comboBox3.SelectedItem.ToString() == "Gender")
            {
                CNICSearch.Visible = false;
                NameSearch.Visible = false;
                GenderSearch.Visible = true;

            }
            if (comboBox3.SelectedItem.ToString() == "CNIC")
            {
                NameSearch.Visible = false;
                GenderSearch.Visible = false;
                CNICSearch.Visible = true;
                

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "Delete from users WHERE CNIC=" + double.Parse(UpdateCNICTB.Text);
                executeQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Managment Project Made by M. Hassan Niazi","About");
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu newMainMenu = new Main_Menu();
            newMainMenu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
