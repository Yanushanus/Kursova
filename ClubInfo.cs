using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Kursova
{
    public partial class ClubInfo : Form
    {
        public ClubInfo()
        {
            InitializeComponent();
            
        }


       

      
        

        
       

        private void YogaBut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            yoga yoga = new yoga();
            yoga.Show();
        }

        private void TennisBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            tennis tennis = new tennis();
            tennis.Show();
        }

        private void BoxBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            box box = new box();
            box.Show();
        }

        private void VolleyballBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            volleyball volleyball = new volleyball();
            volleyball.Show();
        }

        private void GymBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gym gym = new Gym();
            gym.Show();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}