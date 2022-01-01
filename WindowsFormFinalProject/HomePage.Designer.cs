
namespace WindowsFormFinalProject
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.sideBar = new System.Windows.Forms.Panel();
            this.navBar = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btnWareHouse = new XanderUI.XUIButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sideBar.Controls.Add(this.btnWareHouse);
            this.sideBar.Controls.Add(this.xuiButton1);
            this.sideBar.Controls.Add(this.logo);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(230, 753);
            this.sideBar.TabIndex = 0;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(230, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1052, 130);
            this.navBar.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 128);
            this.logo.TabIndex = 0;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiButton1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(0, 128);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(230, 80);
            this.xuiButton1.TabIndex = 1;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnWareHouse.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnWareHouse.ButtonImage")));
            this.btnWareHouse.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnWareHouse.ButtonText = "Button";
            this.btnWareHouse.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnWareHouse.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWareHouse.CornerRadius = 5;
            this.btnWareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWareHouse.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWareHouse.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWareHouse.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnWareHouse.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWareHouse.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnWareHouse.Location = new System.Drawing.Point(0, 208);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Size = new System.Drawing.Size(230, 80);
            this.btnWareHouse.TabIndex = 2;
            this.btnWareHouse.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnWareHouse.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWareHouse.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 130);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1052, 623);
            this.panelMain.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.sideBar);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel navBar;
        private XanderUI.XUIButton btnWareHouse;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Panel panelMain;
    }
}