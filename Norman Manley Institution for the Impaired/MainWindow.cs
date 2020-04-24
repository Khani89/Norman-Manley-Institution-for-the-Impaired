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
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Ulogin login)
        {
            InitializeComponent();
            Login = login;
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
    }
}
