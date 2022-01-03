
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductDetail
            // 
            this.dataGridProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductDetail.Location = new System.Drawing.Point(64, 215);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridDetailPrd
            // 
            this.dataGridDetailPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailPrd.Location = new System.Drawing.Point(329, 215);
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
            this.xuiButtonDetailPrd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButtonDetailPrd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonDetailPrd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButtonDetailPrd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonDetailPrd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButtonDetailPrd.Location = new System.Drawing.Point(329, 131);
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
            this.xuiButton1Load.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1Load.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1Load.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1Load.Location = new System.Drawing.Point(64, 131);
            this.xuiButton1Load.Name = "xuiButton1Load";
            this.xuiButton1Load.Size = new System.Drawing.Size(120, 41);
            this.xuiButton1Load.TabIndex = 2;
            this.xuiButton1Load.TextColor = System.Drawing.Color.Black;
            this.xuiButton1Load.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.Click += new System.EventHandler(this.xuiButton1Load_Click);
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.dataGridDetailPrd);
            this.Controls.Add(this.xuiButtonDetailPrd);
            this.Controls.Add(this.xuiButton1Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProductDetail);
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailPrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductDetail;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1Load;
        private XanderUI.XUIButton xuiButtonDetailPrd;
        private System.Windows.Forms.DataGridView dataGridDetailPrd;
    }
}