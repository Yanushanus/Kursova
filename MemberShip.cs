using System;
using System.Linq;
using System.Windows.Forms;

namespace Kursova
{
    public partial class MemberShip : Form
    {
        public MemberShip()
        {
            InitializeComponent();
        }

        static void InsertName(ref string[] Name, string value)
        {
            string[] NewName = new string[Name.Length + 1];
            for (int i = 0; i < 4; i++)
            {
                NewName[i] = Name[i];
            }

            Name = NewName;
        }
        public int[] Price;
        public string[] Schedule;

        
        private void GymBut_Click(object sender, EventArgs e)
        {
            
            
        }

        private void VolleyballBut_Click(object sender, EventArgs e)
        {
           
        }

        private void BoxBut_Click(object sender, EventArgs e)
        {
            
        }

        private void YogaBut_Click(object sender, EventArgs e)
        {
            
        }

        private void TennisBut_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfirmBut_Click(object sender, EventArgs e)
        {
            
        }
    }
}