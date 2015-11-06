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
    public partial class admins : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;database=dbhassan;port=3306;username=root;password=nasa");
        MySqlCommand mcd;
        int adminAccess, ManagmentAccess, AccountsAccess;
        public admins()
        {
            InitializeComponent();
               

          
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (Password.Text == ConfirmPassword.Text)
                {
                    
                    if (hasAdminAcc.Checked)
                    {
                        adminAccess = 1;
                    }
                    else
                    {
                        adminAccess = 0;
                    }

                    if (hasManagAcc.Checked)
                    {
                        ManagmentAccess = 1;
                    }
                    else
                    {
                        ManagmentAccess = 0;
                    }

                    if (HasAccountPortalAcc.Checked)
                    {
                        AccountsAccess = 1;
                    }
                    else
                    {
                        AccountsAccess = 0;
                    }
                    string query;
                    query = "INSERT INTO admins values('" + UserName.Text + "','" + Password.Text + "'," + adminAccess.ToString() + "," + ManagmentAccess.ToString() + "," + AccountsAccess.ToString() + ")";
                    executeQuery(query);
                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        public void openSqlConnection()
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from admins", myConn);
                Adapter.Fill(readerDataSet);
                dataGridView1.DataSource = readerDataSet.Tables[0];
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
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from admins where user_id='"+ UpdateUserId.Text + "'", myConn);
                Adapter.Fill(readerDataSet);
               UpdatePassword.Text = (string)readerDataSet.Tables[0].Rows[0].ItemArray[1];
                UpdateConfirmPassword.Text= (string)readerDataSet.Tables[0].Rows[0].ItemArray[1];
                UpHasAdmin.Checked = ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[2] == 1);
                UpHasManag.Checked= ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[3]==1);
                UpHasAccount.Checked = ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[4]==1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not Found!", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateConfirmPassword.Text == UpdatePassword.Text)
                {
                    string query;
                    query = "Delete from admins WHERE user_id='" + UpdateUserId.Text + "'";
                    executeQuery(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accounts Managment Made By M. Hassan Niazi","About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                try
                {
                if (UpdatePassword.Text == UpdateConfirmPassword.Text)
                { 

                    if (UpHasAdmin.Checked)
                    {
                        adminAccess = 1;
                    }
                    else
                    {
                        adminAccess = 0;
                    }

                    if (UpHasManag.Checked)
                    {
                        ManagmentAccess = 1;
                    }
                    else
                    {
                        ManagmentAccess = 0;
                    }

                    if (UpHasAccount.Checked)
                    {
                        AccountsAccess = 1;
                    }
                    else
                    {
                        AccountsAccess = 0;
                    }
                    string query;
                    query = "UPDATE admins SET Password='" + UpdatePassword.Text + "',AdminAccess=" + adminAccess.ToString() + ",managmentAccess=" + ManagmentAccess.ToString() + ",accountsaccess='" + AccountsAccess.ToString() + " WHERE user_id='" + UpdateUserId.Text + "'";
                    executeQuery(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu newMainMenu = new Main_Menu();
            newMainMenu.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == ConfirmPassword.Text)
            {
                Password.BackColor = Color.White;
                ConfirmPassword.BackColor = Color.White;
            }
            else
            {
                Password.BackColor = Color.Red;
                ConfirmPassword.BackColor = Color.Red;
            }
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == ConfirmPassword.Text)
            {
                Password.BackColor = Color.White;
                ConfirmPassword.BackColor = Color.White;
            }
            else
            {
                Password.BackColor = Color.Red;
                ConfirmPassword.BackColor = Color.Red;
            }
        }

        private void UpdatePassword_TextChanged(object sender, EventArgs e)
        {
            if (UpdatePassword.Text == UpdateConfirmPassword.Text)
            {
                UpdatePassword.BackColor = Color.White;
                UpdateConfirmPassword.BackColor = Color.White;
            }
            else
            {
                UpdatePassword.BackColor = Color.Red;
                UpdateConfirmPassword.BackColor = Color.Red;
            }
        }

        private void UpdateConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (UpdatePassword.Text == UpdateConfirmPassword.Text)
            {
                UpdatePassword.BackColor = Color.White;
                UpdateConfirmPassword.BackColor = Color.White;
            }
            else
            {
                UpdatePassword.BackColor = Color.Red;
                UpdateConfirmPassword.BackColor = Color.Red;
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
    }
}
