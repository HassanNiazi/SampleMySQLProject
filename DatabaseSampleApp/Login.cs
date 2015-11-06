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
    public partial class Login : Form
    {
        MySqlConnection myConn = new MySqlConnection("datasource=localhost;database=dbhassan;port=3306;username=root;password=nasa");
        MySqlCommand mcd;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                  //  toolStripStatusLabel1.Text = "Query Executed";
                }
                else
                {
                  //  toolStripStatusLabel1.Text = "Query Not Executed";
                }
            }
            catch (Exception ex)
            {
              //  toolStripStatusLabel1.Text = ex.Message;
            }
            finally
            {
                closeSqlConnection();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet readerDataSet = new DataSet();
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from admins where user_id='" + UserName.Text + "'", myConn);
                Adapter.Fill(readerDataSet);
                if( UserName.Text == (string)readerDataSet.Tables[0].Rows[0].ItemArray[0]&& Password.Text == (string)readerDataSet.Tables[0].Rows[0].ItemArray[1])
                {
                    Main_Menu mainMenu = new Main_Menu(UserName.Text,
                        ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[2] == 1),
                        ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[3] == 1),
                        ((SByte)readerDataSet.Tables[0].Rows[0].ItemArray[4] == 1));
                    this.Hide();
                    mainMenu.Show();

                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "Warning");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid User Name or Password", "Warning");
            }
        }
    }
}
