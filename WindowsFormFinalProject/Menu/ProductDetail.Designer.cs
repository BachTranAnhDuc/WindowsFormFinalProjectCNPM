
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetail));
            this.dataGridProductDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiButton1Load = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductDetail
            // 
            this.dataGridProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductDetail.Location = new System.Drawing.Point(111, 49);
            this.dataGridProductDetail.Name = "dataGridProductDetail";
            this.dataGridProductDetail.RowHeadersWidth = 51;
            this.dataGridProductDetail.RowTemplate.Height = 24;
            this.dataGridProductDetail.Size = new System.Drawing.Size(342, 225);
            this.dataGridProductDetail.TabIndex = 0;
            this.dataGridProductDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductDetail_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // xuiButton1Load
            // 
            this.xuiButton1Load.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1Load.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1Load.ButtonImage")));
            this.xuiButton1Load.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1Load.ButtonText = "Button";
            this.xuiButton1Load.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1Load.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.CornerRadius = 5;
            this.xuiButton1Load.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1Load.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1Load.Location = new System.Drawing.Point(341, 301);
            this.xuiButton1Load.Name = "xuiButton1Load";
            this.xuiButton1Load.Size = new System.Drawing.Size(97, 31);
            this.xuiButton1Load.TabIndex = 2;
            this.xuiButton1Load.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1Load.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1Load.Click += new System.EventHandler(this.xuiButton1Load_Click);
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.xuiButton1Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProductDetail);
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductDetail;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1Load;
    }
}