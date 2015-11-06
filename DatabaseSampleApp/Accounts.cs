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
    public partial class Accounts : Form
    {


        MySqlConnection myConn = new MySqlConnection("datasource=localhost;database=dbhassan;port=3306;username=root;password=nasa");
        MySqlCommand mcd;
        bool validDataForAccount=false;
        public Accounts()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu newMainMenu = new Main_Menu();
            newMainMenu.Show();
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


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Managment Project Made by M. Hassan Niazi", "About");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where CNIC=" + double.Parse(CNICTB.Text), myConn);
                Adapter.Fill(readerDataSet);
                FNameTB.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[0] + " " + (string)readerDataSet.Tables[0].Rows[0].ItemArray[1];
                JobTitleTB.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[4];
                validDataForAccount = true;
            }
            catch
            {
                validDataForAccount = true;
                MessageBox.Show("No Record for this CNIC","Warning");
            }

         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                button2_Click(sender, e);
                if (validDataForAccount)
                {
                    string query;
                    query = "INSERT INTO accounts (CNIC,Balance,AnnualPay) values(" + CNICTB.Text + "," + BalanceTB.Text + "," + AnnualPayTB.Text + ")";
                    executeQuery(query);
                    validDataForAccount = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                validDataForAccount = false;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from users where CNIC=" + double.Parse(UpdateCNICTB.Text), myConn);
                Adapter.Fill(readerDataSet);
                UpNameButton.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[0] + " " + (string)readerDataSet.Tables[0].Rows[0].ItemArray[1];
                UpJobTitleTB.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[4];

                readerDataSet = new DataSet();
                Adapter = new MySqlDataAdapter("select * from accounts where CNIC=" + double.Parse(UpdateCNICTB.Text), myConn);
                Adapter.Fill(readerDataSet);

                UpBalanceTB.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[2];
                UpAnnualPayTB.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[3];
                validDataForAccount = true;
            }
            catch
            {
                validDataForAccount = true;
                MessageBox.Show("No Record for this CNIC", "Warning");
            }
        }
    }
}
