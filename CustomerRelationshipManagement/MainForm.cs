using System;
using System.Windows.Forms;

namespace CustomerRelationshipManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MemberSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void MemberRegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }
    }
}
