using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        public int Discount(int sum)

        {
            int discount;
            if (sum == 500)
            {
                sum = sum;
            }
            else if (sum == 800)
            {
                discount = sum * 5 / 100;
                sum = sum - discount;
            }
            else if (sum == 900)
            {
                discount = sum * 10 / 100;
                sum = sum - discount;
            }
            else if (sum == 1000)
            {
                discount = sum * 15 / 100;
                sum = sum - discount;
            }
            else if (sum == 1200)
            {
                discount = sum * 20 / 100;
                sum = sum - discount;
            }

            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum = 0;
            
            string s = "";
            

            switch (comboBox1.Text)
            {

                case "Box":

                    Club Box = new Club("Box", 1000, "Monday 18:00 Tuesday 17:00 Friday 16:00");
                    s = s + "\nYour club:" + Box.club + "Your schedule:" + Box.schedule;
                    sum += Box.price;
                    

                    break;
                case "Gym":
                    Club Gym = new Club("Gym", 500, "Monday 16:00 Wednesday 18:00 Sunday 16:00");
                    s = s + "\nYour club:" + Gym.club + "Your schedule:" + Gym.schedule;
                    sum += Gym.price;
                   
                    break;
                case "Tennis":
                    Club Tennis = new Club("Tennis", 1200, "Wednesday 16:00 Friday 14:00 Saturday 17:00");
                    s = s + "\nYour club:" + Tennis.club + "Your schedule:" + Tennis.schedule;
                    sum += Tennis.price;
                   
                    break;
                case "Volleyball":
                    Club Volleyball = new Club("Volleyball", 800, "Tuesday 14:00 Thursday 14:00 Saturday 14:00");
                    s = s + "\nYour club:" + Volleyball.club + "Your schedule:" + Volleyball.schedule;
                    sum += Volleyball.price;
                    
                    break;
                case "Yoga":
                    Club Yoga = new Club("Yoga", 900, "Tuesday 16:00 Thursday 16:00 Sunday 16:00");
                    s = s + "\nYour club:" + Yoga.club + "Your schedule:" + Yoga.schedule;
                    sum += Yoga.price;
                    
                    break;

            }

            int result = Discount(sum);
            string res ="\nYour price:"+ Convert.ToString(result);
            s = s + res;
            richTextBox1.Text = s;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
