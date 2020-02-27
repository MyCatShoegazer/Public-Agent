namespace PublicAgentDesktop.Ui.Dialogs
{
    partial class SignUpDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rePasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.additionalCredentialsGroupBox = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browsePhotoButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.additionalCredentialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.photoGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(26, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(68, 17);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(166, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(68, 43);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(166, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // rePasswordTextBox
            // 
            this.rePasswordTextBox.Location = new System.Drawing.Point(68, 69);
            this.rePasswordTextBox.Name = "rePasswordTextBox";
            this.rePasswordTextBox.Size = new System.Drawing.Size(166, 20);
            this.rePasswordTextBox.TabIndex = 4;
            this.rePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Controls.Add(this.rePasswordTextBox);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main credentials";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(30, 20);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(71, 17);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(24, 46);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone:";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(71, 43);
            this.phoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(163, 20);
            this.phoneMaskedTextBox.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 72);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(71, 69);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 98);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(71, 95);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.firstNameTextBox.TabIndex = 14;
            // 
            // additionalCredentialsGroupBox
            // 
            this.additionalCredentialsGroupBox.Controls.Add(this.emailLabel);
            this.additionalCredentialsGroupBox.Controls.Add(this.firstNameTextBox);
            this.additionalCredentialsGroupBox.Controls.Add(this.emailTextBox);
            this.additionalCredentialsGroupBox.Controls.Add(this.firstNameLabel);
            this.additionalCredentialsGroupBox.Controls.Add(this.phoneLabel);
            this.additionalCredentialsGroupBox.Controls.Add(this.lastNameTextBox);
            this.additionalCredentialsGroupBox.Controls.Add(this.phoneMaskedTextBox);
            this.additionalCredentialsGroupBox.Controls.Add(this.lastNameLabel);
            this.additionalCredentialsGroupBox.Location = new System.Drawing.Point(12, 116);
            this.additionalCredentialsGroupBox.Name = "additionalCredentialsGroupBox";
            this.additionalCredentialsGroupBox.Size = new System.Drawing.Size(244, 127);
            this.additionalCredentialsGroupBox.TabIndex = 15;
            this.additionalCredentialsGroupBox.TabStop = false;
            this.additionalCredentialsGroupBox.Text = "Additional credentials";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(262, 195);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(177, 23);
            this.applyButton.TabIndex = 16;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(262, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(177, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(165, 123);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 18;
            this.photoPictureBox.TabStop = false;
            // 
            // photoGroupBox
            // 
            this.photoGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.photoGroupBox.Location = new System.Drawing.Point(262, 12);
            this.photoGroupBox.Name = "photoGroupBox";
            this.photoGroupBox.Size = new System.Drawing.Size(177, 177);
            this.photoGroupBox.TabIndex = 19;
            this.photoGroupBox.TabStop = false;
            this.photoGroupBox.Text = "Photo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.browsePhotoButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.photoPictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // browsePhotoButton
            // 
            this.browsePhotoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browsePhotoButton.Location = new System.Drawing.Point(3, 132);
            this.browsePhotoButton.Name = "browsePhotoButton";
            this.browsePhotoButton.Size = new System.Drawing.Size(165, 23);
            this.browsePhotoButton.TabIndex = 20;
            this.browsePhotoButton.Text = "Browse...";
            this.browsePhotoButton.UseVisualStyleBackColor = true;
            this.browsePhotoButton.Click += new System.EventHandler(this.browsePhotoButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "photo";
            this.openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog.Title = "Choose photo";
            // 
            // SignUpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.photoGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.additionalCredentialsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SignUpDialog";
            this.Text = "SignUpDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.additionalCredentialsGroupBox.ResumeLayout(false);
            this.additionalCredentialsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.photoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox rePasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.GroupBox additionalCredentialsGroupBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.GroupBox photoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button browsePhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}