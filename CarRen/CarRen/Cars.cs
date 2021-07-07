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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-CNP1N0H\SQLEXPRESS;Initial Catalog=CaRReNdb;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from CarTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (RegNoTxt.Text == "" || BrandTxt.Text == "" || ModelTxt.Text == "" || PriceTxt.Text == "")
            {
                MessageBox.Show("Please enter your details");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into CarTbl values('" + RegNoTxt.Text + "','" + BrandTxt.Text + "','" + ModelTxt.Text + "','" + AvaliableCb.SelectedItem.ToString() + "','" + PriceTxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            populate();
            CarsDgv.Columns[0].HeaderCell.Value = "RegNo";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (RegNoTxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTbl where RegNumber='" + RegNoTxt.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Deleted ");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNoTxt.Text = CarsDgv.SelectedRows[0].Cells[0].Value.ToString();
            BrandTxt.Text = CarsDgv.SelectedRows[0].Cells[1].Value.ToString();
            ModelTxt.Text = CarsDgv.SelectedRows[0].Cells[2].Value.ToString();
            AvaliableCb.SelectedItem = CarsDgv.SelectedRows[0].Cells[3].Value.ToString();
            PriceTxt.Text = CarsDgv.SelectedRows[0].Cells[4].Value.ToString();
       


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (RegNoTxt.Text == "" || BrandTxt.Text == "" || ModelTxt.Text == "" || PriceTxt.Text == "")
            {
                MessageBox.Show("Please enter your details");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "update CarTbl set Brand='" + BrandTxt.Text + "', Model='" + ModelTxt.Text + "', Avaliable = '" + AvaliableCb.SelectedItem.ToString() + "', Price ='" + PriceTxt.Text + "' where RegNumber='" + RegNoTxt.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsPL carsPL = new CarsPL();
            carsPL.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars cars = new Cars();
            cars.Show();
        }
    }
}
