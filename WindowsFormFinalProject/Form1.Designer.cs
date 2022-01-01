
namespace WindowsFormFinalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Location = new System.Drawing.Point(247, 314);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(169, 22);
            this.passwordInput.TabIndex = 12;
            // 
            // usernameInput
            // 
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Location = new System.Drawing.Point(247, 242);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(169, 22);
            this.usernameInput.TabIndex = 11;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(109, 316);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 30);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(98, 234);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 30);
            this.username.TabIndex = 9;
            this.username.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login Form";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.ButtonImage")));
            this.btnSubmit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSubmit.ButtonText = "Button";
            this.btnSubmit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSubmit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.CornerRadius = 5;
            this.btnSubmit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSubmit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSubmit.Location = new System.Drawing.Point(247, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.ali_karimiboroujeni_Qaq9q05ZIYU_unsplash;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(579, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 464);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnSubmit;
        private System.Windows.Forms.Panel panel1;
    }
}

