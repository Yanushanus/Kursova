using System;
using System.Windows.Forms;

namespace Kursova
{
    public partial class MainMenu : Form
    {
        
        
        public MainMenu()
        {
            InitializeComponent();
            
            

         
    }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubInfo clubInfo = new ClubInfo();
            clubInfo.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member member = new Member();
            member.Show();
        }
    }
}