
namespace WindowsFormFinalProject.Menu
{
    partial class CustomerBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xuiButtonShow = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // xuiButtonShow
            // 
            this.xuiButtonShow.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButtonShow.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_view_details_96;
            this.xuiButtonShow.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButtonShow.ButtonText = "View";
            this.xuiButtonShow.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButtonShow.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonShow.CornerRadius = 5;
            this.xuiButtonShow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButtonShow.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonShow.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButtonShow.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonShow.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButtonShow.Location = new System.Drawing.Point(364, 62);
            this.xuiButtonShow.Name = "xuiButtonShow";
            this.xuiButtonShow.Size = new System.Drawing.Size(120, 37);
            this.xuiButtonShow.TabIndex = 2;
            this.xuiButtonShow.TextColor = System.Drawing.Color.Black;
            this.xuiButtonShow.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonShow.Click += new System.EventHandler(this.xuiButtonShow_Click);
            // 
            // CustomerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiButtonShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerBill";
            this.Load += new System.EventHandler(this.CustomerBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private XanderUI.XUIButton xuiButtonShow;
    }
}