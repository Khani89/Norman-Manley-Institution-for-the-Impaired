using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norman_Manley_Institution_for_the_Impaired
{
    public partial class Ulogin : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;
        public Ulogin()
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                 
                var Username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();

                var user = ManageData.Users.FirstOrDefault(k => k.UserName == Username && k.Password == hashed_password);
                if (user == null)
                {
                    MessageBox.Show("Please provide correct credentials");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortname = role.Role.Shortname;
                    var mainWindow = new MainWindow(this, roleShortname);
                    mainWindow.Show();
                    Hide(); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went Wrong, Please try again"); 
            }
            

            
        }
    }
}
