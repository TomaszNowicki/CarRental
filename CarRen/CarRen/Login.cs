using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CarRen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-CNP1N0H\SQLEXPRESS;Initial Catalog=CaRReNdb;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPL loginPL = new LoginPL();
            loginPL.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoginTxt.Text = "";
            PasswordTxt.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from UserTbl where UserName='" + LoginTxt.Text + "' and UserPassword='" + PasswordTxt.Text + "'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                Main main = new Main();
                main.Show();
            }

            else

            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }
        private void PasswordTxt_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = guna2Button1;
        }

        private void PasswordTxt_Enter_1(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = guna2Button1;
        }
    }
}
