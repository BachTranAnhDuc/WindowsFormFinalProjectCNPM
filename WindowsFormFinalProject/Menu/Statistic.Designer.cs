
namespace WindowsFormFinalProject.Menu
{
    partial class Statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            this.xuiLineGraph1 = new XanderUI.XUILineGraph();
            this.xuiBarGraph1 = new XanderUI.XUIBarGraph();
            this.SuspendLayout();
            // 
            // xuiLineGraph1
            // 
            this.xuiLineGraph1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiLineGraph1.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiLineGraph1.BorderColor = System.Drawing.Color.White;
            this.xuiLineGraph1.GraphStyle = XanderUI.XUILineGraph.Style.Material;
            this.xuiLineGraph1.GraphTitle = "XUI LineGraph";
            this.xuiLineGraph1.GraphTitleColor = System.Drawing.Color.Gray;
            this.xuiLineGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiLineGraph1.Items")));
            this.xuiLineGraph1.LineColor = System.Drawing.Color.White;
            this.xuiLineGraph1.Location = new System.Drawing.Point(685, 109);
            this.xuiLineGraph1.Name = "xuiLineGraph1";
            this.xuiLineGraph1.PointSize = 7;
            this.xuiLineGraph1.ShowBorder = false;
            this.xuiLineGraph1.ShowPoints = true;
            this.xuiLineGraph1.ShowTitle = false;
            this.xuiLineGraph1.ShowVerticalLines = false;
            this.xuiLineGraph1.Size = new System.Drawing.Size(391, 325);
            this.xuiLineGraph1.TabIndex = 1;
            this.xuiLineGraph1.Text = "xuiLineGraph1";
            this.xuiLineGraph1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.xuiLineGraph1.VerticalLineColor = System.Drawing.Color.DimGray;
            // 
            // xuiBarGraph1
            // 
            this.xuiBarGraph1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.xuiBarGraph1.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
            this.xuiBarGraph1.GraphStyle = XanderUI.XUIBarGraph.Style.Material;
            this.xuiBarGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiBarGraph1.Items")));
            this.xuiBarGraph1.Location = new System.Drawing.Point(109, 109);
            this.xuiBarGraph1.Name = "xuiBarGraph1";
            this.xuiBarGraph1.ShowGrid = false;
            this.xuiBarGraph1.Size = new System.Drawing.Size(423, 325);
            this.xuiBarGraph1.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
            this.xuiBarGraph1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.xuiBarGraph1.TabIndex = 2;
            this.xuiBarGraph1.Text = "xuiBarGraph1";
            this.xuiBarGraph1.TextAlignment = XanderUI.XUIBarGraph.Aligning.Far;
            this.xuiBarGraph1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.xuiBarGraph1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.xuiBarGraph1);
            this.Controls.Add(this.xuiLineGraph1);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUILineGraph xuiLineGraph1;
        private XanderUI.XUIBarGraph xuiBarGraph1;
    }
}