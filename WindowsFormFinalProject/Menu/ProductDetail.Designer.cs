
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
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.dataGridProductDetail);
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductDetail;
    }
}