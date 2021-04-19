using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class tennis : Form
    {
        public tennis()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubInfo clubInfo = new ClubInfo();
            clubInfo.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Tennis";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1200";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Malina John";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "A huge hall with two tennis courts";
        }

       

       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Wednesday 16:00 Friday 14:00 Saturday 17:00";

        }
    }
    }
