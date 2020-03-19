using PublicAgentDesktop.Data;
using PublicAgentDesktop.Data.Models;
using PublicAgentDesktop.Utility;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            if (this.passwordTextBox.Text != this.rePasswordTextBox.Text)
            {
                MessageBox.Show(
                    "Password are not the same. Please check and try again.",
                    "Registration error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (var context = new PublicAgentDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Login == this.loginTextBox.Text);
                if (user != null)
                {
                    MessageBox.Show(
                        "User with this login or password already registered. Please, choose another one.",
                        "Registration error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    user = new User
                    {
                        Login = this.loginTextBox.Text,
                        Password = this.passwordTextBox.Text,
                        Email = this.emailTextBox.Text,
                        LastName = this.lastNameTextBox.Text,
                        FirstName = this.firstNameTextBox.Text,
                        Phone = this.phoneMaskedTextBox.Text,
                        Photo = (byte[])(new ImageConverter()).ConvertTo(this.photoPictureBox.Image, typeof(byte[])),
                        Group = context.Groups.FirstOrDefault(x => x.Name == "Пользователи")
                    };

                    context.Users.Add(user);
                    Debug.WriteLine($"Rows affected[Registration]: {context.SaveChanges()}");

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Registration error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
