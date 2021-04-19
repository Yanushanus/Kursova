using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class volleyball : Form
    {
        public volleyball()
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
            textBox1.Text = "Volleyball";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "800";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Karimov John";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "A huge volleyball hall with 3 playgrounds";
        }

        
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Tuesday 14:00 Thursday 14:00 Saturday 14:00";


        }
    }
}