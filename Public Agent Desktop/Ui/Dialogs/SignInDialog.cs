using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicAgentDesktop.Ui.Dialogs
{
    public partial class SignInDialog : Form
    {
        public SignInDialog()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (new SignUpDialog().ShowDialog(this) == DialogResult.OK)
            {
                //do something else
            }
        }
    }
}
