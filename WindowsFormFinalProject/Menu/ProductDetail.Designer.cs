
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
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
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
    }
}