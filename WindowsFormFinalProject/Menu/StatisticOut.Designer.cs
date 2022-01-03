
namespace WindowsFormFinalProject.Menu
{
    partial class StatisticOut
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(273, 393);
            this.dataGridView1.TabIndex = 9;
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(79, 41);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "priceIn";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(614, 393);
            this.Chart1.TabIndex = 8;
            this.Chart1.Text = "chart1";
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton2.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_tv_show_96;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Show";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(79, 42);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(129, 41);
            this.xuiButton2.TabIndex = 11;
            this.xuiButton2.TextColor = System.Drawing.Color.Black;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_view_details_96;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "View";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(49, 42);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(124, 41);
            this.xuiButton1.TabIndex = 10;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 111);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.xuiButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(766, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 111);
            this.panel5.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xuiButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 111);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(766, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 465);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Chart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 465);
            this.panel4.TabIndex = 14;
            // 
            // StatisticOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StatisticOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatisticOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}