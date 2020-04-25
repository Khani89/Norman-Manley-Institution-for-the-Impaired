using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norman_Manley_Institution_for_the_Impaired
{
    public partial class MainWindow : Form
    {
        private Ulogin Login;
        public String RoleName;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Ulogin login, String roleShortname)
        {
            InitializeComponent();
            Login = login;
            RoleName = roleShortname;
        }


        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(k => k.Name == "ManageStudentData");
            if (!isOpen)
            {
                var studentinformation = new ManageStudentData();
                studentinformation.MdiParent = this;
                studentinformation.Show();
            }

           
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(RoleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
