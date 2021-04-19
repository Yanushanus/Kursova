using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursova
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
           
        }

        private void SignUpBut_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passUser = PasswordBox.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE `login`=@uL AND `pass`=@uP",db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You have been Authorized");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("You haven't been Authorized");
            }
            
        }

        private void registrateBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}