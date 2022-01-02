
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
            this.sideBar = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.navBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btnCustomer = new XanderUI.XUIButton();
            this.btnBill = new XanderUI.XUIButton();
            this.btnWareHouse = new XanderUI.XUIButton();
            this.btnHome = new XanderUI.XUIButton();
            this.sideBar.SuspendLayout();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.sideBar.Controls.Add(this.xuiButton3);
            this.sideBar.Controls.Add(this.xuiButton2);
            this.sideBar.Controls.Add(this.xuiButton1);
            this.sideBar.Controls.Add(this.btnCustomer);
            this.sideBar.Controls.Add(this.btnBill);
            this.sideBar.Controls.Add(this.btnWareHouse);
            this.sideBar.Controls.Add(this.btnHome);
            this.sideBar.Controls.Add(this.logo);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(230, 753);
            this.sideBar.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(186)))), ((int)(((byte)(161)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 130);
            this.logo.TabIndex = 0;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.navBar.Controls.Add(this.iconMinimize);
            this.navBar.Controls.Add(this.iconExit);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(230, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1152, 130);
            this.navBar.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 130);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1152, 623);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(1064, 0);
            this.iconMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(40, 37);
            this.iconMinimize.TabIndex = 6;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(1112, 0);
            this.iconExit.Margin = new System.Windows.Forms.Padding(4);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(40, 37);
            this.iconExit.TabIndex = 5;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.xuiButton3.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_logout_rounded_left_96;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "LOG OUT";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(0, 673);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(230, 80);
            this.xuiButton3.TabIndex = 7;
            this.xuiButton3.TextColor = System.Drawing.Color.GhostWhite;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.xuiButton2.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_line_chart_96;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "STATISTIC";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(0, 530);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(230, 80);
            this.xuiButton2.TabIndex = 6;
            this.xuiButton2.TextColor = System.Drawing.Color.GhostWhite;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.xuiButton1.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_shopping_cart_96;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "PRODUCT";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(0, 450);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(230, 80);
            this.xuiButton1.TabIndex = 5;
            this.xuiButton1.TextColor = System.Drawing.Color.GhostWhite;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnCustomer.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_manager_96;
            this.btnCustomer.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCustomer.ButtonText = "MANAGE";
            this.btnCustomer.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCustomer.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.CornerRadius = 5;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCustomer.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCustomer.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCustomer.Location = new System.Drawing.Point(0, 370);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(230, 80);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.TextColor = System.Drawing.Color.GhostWhite;
            this.btnCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnBill
            // 
            this.btnBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnBill.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_bill_96;
            this.btnBill.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnBill.ButtonText = "BILL";
            this.btnBill.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnBill.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBill.CornerRadius = 5;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBill.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnBill.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBill.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnBill.Location = new System.Drawing.Point(0, 290);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(230, 80);
            this.btnBill.TabIndex = 3;
            this.btnBill.TextColor = System.Drawing.Color.GhostWhite;
            this.btnBill.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnWareHouse.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_shop_96;
            this.btnWareHouse.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnWareHouse.ButtonText = "WARE HOUSE";
            this.btnWareHouse.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnWareHouse.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWareHouse.CornerRadius = 5;
            this.btnWareHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWareHouse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWareHouse.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWareHouse.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnWareHouse.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnWareHouse.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnWareHouse.Location = new System.Drawing.Point(0, 210);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Size = new System.Drawing.Size(230, 80);
            this.btnWareHouse.TabIndex = 2;
            this.btnWareHouse.TextColor = System.Drawing.Color.GhostWhite;
            this.btnWareHouse.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnWareHouse.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnHome.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_home_96;
            this.btnHome.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHome.ButtonText = "HOME";
            this.btnHome.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnHome.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.CornerRadius = 5;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHome.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnHome.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 130);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.TextColor = System.Drawing.Color.GhostWhite;
            this.btnHome.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.sideBar.ResumeLayout(false);
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel navBar;
        private XanderUI.XUIButton btnWareHouse;
        private XanderUI.XUIButton btnHome;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton iconExit;
        private XanderUI.XUIButton btnCustomer;
        private XanderUI.XUIButton btnBill;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
    }
}