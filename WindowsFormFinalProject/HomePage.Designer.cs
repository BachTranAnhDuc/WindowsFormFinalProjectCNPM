
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
            this.xuiClock1 = new XanderUI.XUIClock();
            this.navBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textHead = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new XanderUI.XUIButton();
            this.btnStatistic = new XanderUI.XUIButton();
            this.btnProduct = new XanderUI.XUIButton();
            this.btnCustomer = new XanderUI.XUIButton();
            this.btnBill = new XanderUI.XUIButton();
            this.btnWareHouse = new XanderUI.XUIButton();
            this.btnHome = new XanderUI.XUIButton();
            this.sideBar.SuspendLayout();
            this.logo.SuspendLayout();
            this.navBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.sideBar.Controls.Add(this.btnLogOut);
            this.sideBar.Controls.Add(this.btnStatistic);
            this.sideBar.Controls.Add(this.btnProduct);
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
            this.logo.Controls.Add(this.xuiClock1);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 130);
            this.logo.TabIndex = 0;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(44, 4);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(126, 120);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.navBar.Controls.Add(this.panel2);
            this.navBar.Controls.Add(this.panel1);
            this.navBar.Controls.Add(this.label1);
            this.navBar.Controls.Add(this.textHead);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(230, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1152, 130);
            this.navBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconMinimize);
            this.panel1.Controls.Add(this.iconExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1039, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 130);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello, user!";
            // 
            // textHead
            // 
            this.textHead.AutoSize = true;
            this.textHead.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textHead.Location = new System.Drawing.Point(45, 49);
            this.textHead.Name = "textHead";
            this.textHead.Size = new System.Drawing.Size(204, 39);
            this.textHead.TabIndex = 7;
            this.textHead.Text = "Home Page";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 130);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1152, 623);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.Rubik_Shop_2_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(710, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 521);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.Rubik_Shop_1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(157, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 521);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.Rubik1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(599, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 130);
            this.panel2.TabIndex = 11;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(12, 4);
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
            this.iconExit.Location = new System.Drawing.Point(60, 4);
            this.iconExit.Margin = new System.Windows.Forms.Padding(4);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(40, 37);
            this.iconExit.TabIndex = 5;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnLogOut.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_logout_rounded_left_96;
            this.btnLogOut.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogOut.ButtonText = "LOG OUT";
            this.btnLogOut.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLogOut.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.CornerRadius = 5;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLogOut.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogOut.Location = new System.Drawing.Point(0, 673);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 80);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.TextColor = System.Drawing.Color.GhostWhite;
            this.btnLogOut.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnStatistic.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_line_chart_96;
            this.btnStatistic.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnStatistic.ButtonText = "STATISTIC";
            this.btnStatistic.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnStatistic.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStatistic.CornerRadius = 5;
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStatistic.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnStatistic.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStatistic.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnStatistic.Location = new System.Drawing.Point(0, 530);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(230, 80);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.TextColor = System.Drawing.Color.GhostWhite;
            this.btnStatistic.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(157)))), ((int)(((byte)(93)))));
            this.btnProduct.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_shopping_cart_96;
            this.btnProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnProduct.ButtonText = "PRODUCT";
            this.btnProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnProduct.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProduct.CornerRadius = 5;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnProduct.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnProduct.Location = new System.Drawing.Point(0, 450);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(230, 80);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.TextColor = System.Drawing.Color.GhostWhite;
            this.btnProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
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
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
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
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
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
            this.logo.ResumeLayout(false);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
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
        private XanderUI.XUIButton btnLogOut;
        private XanderUI.XUIButton btnStatistic;
        private XanderUI.XUIButton btnProduct;
        private System.Windows.Forms.Label textHead;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}