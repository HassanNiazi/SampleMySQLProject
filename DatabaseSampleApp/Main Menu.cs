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
    public partial class Main_Menu : Form
    {

        MySqlConnection myConn = new MySqlConnection("datasource=localhost;database=dbhassan;port=3306;username=root;password=nasa");
        MySqlCommand mcd;
        public Main_Menu()
        {
            InitializeComponent();
        }

        public Main_Menu(String userName,bool hasAdminAccess,bool hasManagmentAccesss, bool hasAccountsAccess)
        {
            InitializeComponent();
            label1.Text = "Welcome " + userName;
            EmployeeManagmentButton.Enabled = hasManagmentAccesss;
            AdminsAndUsersButton.Enabled = hasAdminAccess;
            AccountButton.Enabled = hasAccountsAccess;

        }
        
        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EmployeeManagment employeeManagmentForm = new EmployeeManagment();
            this.Hide();
            employeeManagmentForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            admins adminsForm = new admins();
            this.Hide();
            adminsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accounts accountsForm = new Accounts();
            this.Hide();
            accountsForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newLogin = new Login();
            newLogin.Show();
        }
    }
}
