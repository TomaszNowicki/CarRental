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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-CNP1N0H\SQLEXPRESS;Initial Catalog=CaRReNdb;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(UserId.Text == "" || UserName.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Please enter your details");
            }
            else 
            {
                try
                {
                    Con.Open();
                    String query = "insert into UserTbl values(" + UserId.Text + ",'" + UserName.Text + "','" + UserPass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Users_Load_1(object sender, EventArgs e)
        {
            populate();
            UserDgv.Columns[1].HeaderCell.Value = "User";
            UserDgv.Columns[2].HeaderCell.Value = "Password";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(UserId.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where Id=" + UserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted ");
                    Con.Close();
                    populate();
                   
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId.Text = UserDgv.SelectedRows[0].Cells[0].Value.ToString();
            UserName.Text = UserDgv.SelectedRows[0].Cells[1].Value.ToString();
            UserPass.Text = UserDgv.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || UserName.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Please enter your details");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "update UserTbl set UserName='" + UserName.Text + "',UserPassword='" + UserPass.Text + "' where Id=" + UserId.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersPL usersPL = new UsersPL();
            usersPL.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }
    }
}
