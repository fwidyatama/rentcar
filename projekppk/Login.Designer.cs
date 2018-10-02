namespace projekppk
{
    partial class Login
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
            this.labelUsername = new MaterialSkin.Controls.MaterialLabel();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.inputUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.checkboxRemember = new MaterialSkin.Controls.MaterialCheckBox();
            this.iconPassword = new System.Windows.Forms.PictureBox();
            this.iconUsername = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Depth = 0;
            this.labelUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUsername.Location = new System.Drawing.Point(82, 114);
            this.labelUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(84, 169);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // inputUsername
            // 
            this.inputUsername.Depth = 0;
            this.inputUsername.Hint = "Input Username";
            this.inputUsername.Location = new System.Drawing.Point(268, 114);
            this.inputUsername.MaxLength = 32767;
            this.inputUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.PasswordChar = '\0';
            this.inputUsername.SelectedText = "";
            this.inputUsername.SelectionLength = 0;
            this.inputUsername.SelectionStart = 0;
            this.inputUsername.Size = new System.Drawing.Size(176, 23);
            this.inputUsername.TabIndex = 2;
            this.inputUsername.TabStop = false;
            this.inputUsername.UseSystemPasswordChar = false;
            // 
            // inputPassword
            // 
            this.inputPassword.Depth = 0;
            this.inputPassword.Hint = "Input Password";
            this.inputPassword.Location = new System.Drawing.Point(268, 169);
            this.inputPassword.MaxLength = 32767;
            this.inputPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '\0';
            this.inputPassword.SelectedText = "";
            this.inputPassword.SelectionLength = 0;
            this.inputPassword.SelectionStart = 0;
            this.inputPassword.Size = new System.Drawing.Size(176, 23);
            this.inputPassword.TabIndex = 3;
            this.inputPassword.TabStop = false;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(0, 332);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = false;
            this.buttonLogin.Size = new System.Drawing.Size(520, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Masuk";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkboxRemember
            // 
            this.checkboxRemember.AutoSize = true;
            this.checkboxRemember.Depth = 0;
            this.checkboxRemember.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxRemember.Location = new System.Drawing.Point(351, 222);
            this.checkboxRemember.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxRemember.Name = "checkboxRemember";
            this.checkboxRemember.Ripple = true;
            this.checkboxRemember.Size = new System.Drawing.Size(93, 30);
            this.checkboxRemember.TabIndex = 6;
            this.checkboxRemember.Text = "ingat saya";
            this.checkboxRemember.UseVisualStyleBackColor = true;
            this.checkboxRemember.CheckedChanged += new System.EventHandler(this.checkboxRemember_Change);
            // 
            // iconPassword
            // 
            this.iconPassword.Image = global::projekppk.Properties.Resources._48_48_9bf01d3a6da700873303e2b4197c3e99_lock;
            this.iconPassword.Location = new System.Drawing.Point(58, 167);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(20, 20);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPassword.TabIndex = 8;
            this.iconPassword.TabStop = false;
            // 
            // iconUsername
            // 
            this.iconUsername.Image = global::projekppk.Properties.Resources.baseline_people_black_18dp;
            this.iconUsername.Location = new System.Drawing.Point(58, 108);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(20, 26);
            this.iconUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUsername.TabIndex = 7;
            this.iconUsername.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 368);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.iconUsername);
            this.Controls.Add(this.checkboxRemember);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "Login";
            this.Text = "Login Pegawai";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelUsername;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputPassword;
        private MaterialSkin.Controls.MaterialFlatButton buttonLogin;
        private MaterialSkin.Controls.MaterialCheckBox checkboxRemember;
        private System.Windows.Forms.PictureBox iconUsername;
        private System.Windows.Forms.PictureBox iconPassword;
    }
}

