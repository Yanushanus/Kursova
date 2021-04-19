using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursova
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            
        }


        private void EndRegistrBut_Click(object sender, EventArgs e)
        {
             
            if (NameBox.Text=="")
            {
                MessageBox.Show("Enter your name");
                return;
            }
            if (SurnameBox.Text=="")
            {
                MessageBox.Show("Enter your surname");
                return;
            }

            string str1 = NameBox.Text;
            int num1;
            bool isnum1 = int.TryParse(str1, out num1);
            if (isnum1)
            {
                MessageBox.Show("You have digits in your name box");
                return;
            }
            string str2 = SurnameBox.Text;
            int num2;
            bool isnum2 = int.TryParse(str2, out num2);
            if (isnum2)
            {
                MessageBox.Show("You have digits in your surname box");
                return;
            }
            if (LoginBox.Text=="")
            {   MessageBox.Show("Enter your login");
                return;
            }
            if (PassBox.Text=="")
            {
                MessageBox.Show("Enter your password");
                return;
            }

            if (isUserExist())
            {
                return;
            }
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`) VALUES ( @login,@password,@name,@surname)",db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value=LoginBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value=PassBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value=NameBox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value=SurnameBox.Text;
            
            db.openConnection();
            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Account was created");
            }
            else
            {
                MessageBox.Show("Account wasn't created");
            }
            
            db.closeConnection();
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE `login`=@uL ",db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Your login already exist,enter new login");
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
    
}