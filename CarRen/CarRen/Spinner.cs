using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRen
{
    public partial class Spinner : Form
    {
        public Spinner()
        {
            InitializeComponent();
        }
        int startp = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            Progress.Value = startp;
            Percent.Text = "" + startp;
            if (Progress.Value == 100)
            {
                Progress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();

            }

        }

        private void Spinner_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Car_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
