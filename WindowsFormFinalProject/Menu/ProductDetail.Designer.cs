
namespace WindowsFormFinalProject.Menu
{
    partial class ProductDetail
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
            this.dataGridProductDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDetailPrd = new System.Windows.Forms.DataGridView();
            this.xuiButtonDetailPrd = new XanderUI.XUIButton();
            this.xuiButton1Load = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailPrd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProductDetail
            // 
            this.dataGridProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductDetail.Location = new System.Drawing.Point(47, 89);
            this.dataGridProductDetail.Name = "dataGridProductDetail";
            this.dataGridProductDetail.RowHeadersWidth = 51;
            this.dataGridProductDetail.RowTemplate.Height = 24;
            this.dataGridProductDetail.Size = new System.Drawing.Size(199, 195);
            this.dataGridProductDetail.TabIndex = 0;
            this.dataGridProductDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductDetail_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridDetailPrd
            // 
            this.dataGridDetailPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailPrd.Location = new System.Drawing.Point(51, 89);
            this.dataGridDetailPrd.Name = "dataGridDetailPrd";
            this.dataGridDetailPrd.RowHeadersWidth = 51;
            this.dataGridDetailPrd.RowTemplate.Height = 24;
            this.dataGridDetailPrd.Size = new System.Drawing.Size(411, 195);
            this.dataGridDetailPrd.TabIndex = 4;
            // 
            // xuiButtonDetailPrd
            // 
            this.xuiButtonDetailPrd.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButtonDetailPrd.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_view_details_96;
            this.xuiButtonDetailPrd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButtonDetailPrd.ButtonText = "Detail";
            this.xuiButtonDetailPrd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButtonDetailPrd.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonDetailPrd.CornerRadius = 5;
            this.xuiButtonDetailPrd.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButtonDetailPrd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonDetailPrd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButtonDetailPrd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonDetailPrd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButtonDetailPrd.Location = new System.Drawing.Point(51, 21);
            this.xuiButtonDetailPrd.Name = "xuiButtonDetailPrd";
            this.xuiButtonDetailPrd.Size = new System.Drawing.Size(135, 41);
            this.xuiButtonDetailPrd.TabIndex = 3;
            this.xuiButtonDetailPrd.TextColor = System.Drawing.Color.Black;
            this.xuiButtonDetailPrd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonDetailPrd.Click += new System.EventHandler(this.xuiButtonDetailPrd_Click);
            // 
            // xuiButton1Load
            // 
            this.xuiButton1Load.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1Load.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_tv_show_96;
            this.xuiButton1Load.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1Load.ButtonText = "Show";
            this.xuiButton1Load.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1Load.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.CornerRadius = 5;
            this.xuiButton1Load.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1Load.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1Load.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1Load.Location = new System.Drawing.Point(47, 21);
            this.xuiButton1Load.Name = "xuiButton1Load";
            this.xuiButton1Load.Size = new System.Drawing.Size(120, 41);
            this.xuiButton1Load.TabIndex = 2;
            this.xuiButton1Load.TextColor = System.Drawing.Color.Black;
            this.xuiButton1Load.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.Click += new System.EventHandler(this.xuiButton1Load_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 102);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 351);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridDetailPrd);
            this.panel4.Controls.Add(this.xuiButtonDetailPrd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(279, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 351);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.xuiButton1Load);
            this.panel3.Controls.Add(this.dataGridProductDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 351);
            this.panel3.TabIndex = 5;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailPrd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductDetail;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1Load;
        private XanderUI.XUIButton xuiButtonDetailPrd;
        private System.Windows.Forms.DataGridView dataGridDetailPrd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}