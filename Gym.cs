using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Gym : Form
    {
        public Gym()
        {
            InitializeComponent();
           
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "Gym";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "500";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Lebovsky Mikhail";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "Huge gym with many training apparatus";
        }

       

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Monday 16:00 Wednesday 18:00 Sunday 16:00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubInfo clubInfo = new ClubInfo();
            clubInfo.Show();
        }
        }
    }
