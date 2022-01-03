
namespace WindowsFormFinalProject.Menu
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet5 = new WindowsFormFinalProject.eShopManagementDataSet5();
            this.customerTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet5TableAdapters.CustomerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFindCus = new System.Windows.Forms.TextBox();
            this.btnFindCusDetail = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordsDataGridViewTextBoxColumn,
            this.nameCusDataGridViewTextBoxColumn,
            this.addressCusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(252, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordsDataGridViewTextBoxColumn
            // 
            this.passwordsDataGridViewTextBoxColumn.DataPropertyName = "passwords";
            this.passwordsDataGridViewTextBoxColumn.HeaderText = "passwords";
            this.passwordsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordsDataGridViewTextBoxColumn.Name = "passwordsDataGridViewTextBoxColumn";
            this.passwordsDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCusDataGridViewTextBoxColumn
            // 
            this.nameCusDataGridViewTextBoxColumn.DataPropertyName = "nameCus";
            this.nameCusDataGridViewTextBoxColumn.HeaderText = "nameCus";
            this.nameCusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCusDataGridViewTextBoxColumn.Name = "nameCusDataGridViewTextBoxColumn";
            this.nameCusDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressCusDataGridViewTextBoxColumn
            // 
            this.addressCusDataGridViewTextBoxColumn.DataPropertyName = "addressCus";
            this.addressCusDataGridViewTextBoxColumn.HeaderText = "addressCus";
            this.addressCusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressCusDataGridViewTextBoxColumn.Name = "addressCusDataGridViewTextBoxColumn";
            this.addressCusDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.eShopManagementDataSet5;
            // 
            // eShopManagementDataSet5
            // 
            this.eShopManagementDataSet5.DataSetName = "eShopManagementDataSet5";
            this.eShopManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFindCus
            // 
            this.textBoxFindCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFindCus.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindCus.Location = new System.Drawing.Point(451, 89);
            this.textBoxFindCus.Name = "textBoxFindCus";
            this.textBoxFindCus.Size = new System.Drawing.Size(184, 36);
            this.textBoxFindCus.TabIndex = 7;
            // 
            // btnFindCusDetail
            // 
            this.btnFindCusDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindCusDetail.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFindCusDetail.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_search_for_love_96_1_;
            this.btnFindCusDetail.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnFindCusDetail.ButtonText = "Search";
            this.btnFindCusDetail.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFindCusDetail.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindCusDetail.CornerRadius = 5;
            this.btnFindCusDetail.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCusDetail.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindCusDetail.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFindCusDetail.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindCusDetail.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFindCusDetail.Location = new System.Drawing.Point(651, 89);
            this.btnFindCusDetail.Name = "btnFindCusDetail";
            this.btnFindCusDetail.Size = new System.Drawing.Size(125, 36);
            this.btnFindCusDetail.TabIndex = 6;
            this.btnFindCusDetail.TextColor = System.Drawing.Color.Black;
            this.btnFindCusDetail.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindCusDetail.Click += new System.EventHandler(this.btnFindCusDetail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxFindCus);
            this.panel1.Controls.Add(this.btnFindCusDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 180);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 396);
            this.panel2.TabIndex = 10;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private eShopManagementDataSet5 eShopManagementDataSet5;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private eShopManagementDataSet5TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFindCus;
        private XanderUI.XUIButton btnFindCusDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}