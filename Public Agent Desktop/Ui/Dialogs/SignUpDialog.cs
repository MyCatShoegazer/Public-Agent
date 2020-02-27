using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PublicAgentDesktop;

namespace PublicAgentDesktop.Ui.Dialogs
{
    public partial class SignUpDialog : Form
    {
        public SignUpDialog()
        {
            InitializeComponent();
        }

        private void browsePhotoButton_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if(File.Exists(this.openFileDialog.FileName))
                {
                    this.photoPictureBox.Image 
                        = Image.FromFile(this.openFileDialog.FileName);
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
