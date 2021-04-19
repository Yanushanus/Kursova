using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class box : Form
    {
        public box()
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
            textBox1.Text = "Box";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Valuev Bob";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "A huge hall with 2 boxing rings";
        }

       

      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Monday 18:00 Tuesday 17:00 Friday 16:00";
        }
    }
    }
