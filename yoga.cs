using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class yoga : Form
    {
        public yoga()
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
            textBox1.Text = "Yoga";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "900";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Mihaza Vella";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "A hall with yoga oriented training apparatus";
        }

      
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Tuesday 16:00 Thursday 16:00 Sunday 16:00";
        }
       

      
    }
}