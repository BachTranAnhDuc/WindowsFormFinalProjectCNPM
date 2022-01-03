
namespace WindowsFormFinalProject.Menu
{
    partial class Products
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
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet3 = new WindowsFormFinalProject.eShopManagementDataSet3();
            this.productTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet3TableAdapters.ProductTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameCateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet4 = new WindowsFormFinalProject.eShopManagementDataSet4();
            this.categoryTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet4TableAdapters.CategoryTableAdapter();
            this.textBoxFindProductCate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindProductCate = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.namePrdDataGridViewTextBoxColumn,
            this.imgDataGridViewTextBoxColumn,
            this.nameCateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // namePrdDataGridViewTextBoxColumn
            // 
            this.namePrdDataGridViewTextBoxColumn.DataPropertyName = "namePrd";
            this.namePrdDataGridViewTextBoxColumn.HeaderText = "namePrd";
            this.namePrdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namePrdDataGridViewTextBoxColumn.Name = "namePrdDataGridViewTextBoxColumn";
            this.namePrdDataGridViewTextBoxColumn.Width = 125;
            // 
            // imgDataGridViewTextBoxColumn
            // 
            this.imgDataGridViewTextBoxColumn.DataPropertyName = "img";
            this.imgDataGridViewTextBoxColumn.HeaderText = "img";
            this.imgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imgDataGridViewTextBoxColumn.Name = "imgDataGridViewTextBoxColumn";
            this.imgDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCateDataGridViewTextBoxColumn
            // 
            this.nameCateDataGridViewTextBoxColumn.DataPropertyName = "nameCate";
            this.nameCateDataGridViewTextBoxColumn.HeaderText = "nameCate";
            this.nameCateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCateDataGridViewTextBoxColumn.Name = "nameCateDataGridViewTextBoxColumn";
            this.nameCateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.eShopManagementDataSet3;
            // 
            // eShopManagementDataSet3
            // 
            this.eShopManagementDataSet3.DataSetName = "eShopManagementDataSet3";
            this.eShopManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.categoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(80, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(176, 341);
            this.dataGridView2.TabIndex = 1;
            // 
            // nameCateDataGridViewTextBoxColumn1
            // 
            this.nameCateDataGridViewTextBoxColumn1.DataPropertyName = "nameCate";
            this.nameCateDataGridViewTextBoxColumn1.HeaderText = "nameCate";
            this.nameCateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameCateDataGridViewTextBoxColumn1.Name = "nameCateDataGridViewTextBoxColumn1";
            this.nameCateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.eShopManagementDataSet4;
            // 
            // eShopManagementDataSet4
            // 
            this.eShopManagementDataSet4.DataSetName = "eShopManagementDataSet4";
            this.eShopManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFindProductCate
            // 
            this.textBoxFindProductCate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindProductCate.Location = new System.Drawing.Point(536, 66);
            this.textBoxFindProductCate.Name = "textBoxFindProductCate";
            this.textBoxFindProductCate.Size = new System.Drawing.Size(216, 36);
            this.textBoxFindProductCate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 172);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.textBoxFindProductCate);
            this.panel6.Controls.Add(this.btnFindProductCate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1134, 172);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1134, 172);
            this.panel5.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 404);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(356, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 404);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 404);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find Detail Category";
            // 
            // btnFindProductCate
            // 
            this.btnFindProductCate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFindProductCate.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_search_for_love_96_1_;
            this.btnFindProductCate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnFindProductCate.ButtonText = "Search";
            this.btnFindProductCate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFindProductCate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindProductCate.CornerRadius = 5;
            this.btnFindProductCate.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProductCate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindProductCate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFindProductCate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindProductCate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFindProductCate.Location = new System.Drawing.Point(779, 66);
            this.btnFindProductCate.Name = "btnFindProductCate";
            this.btnFindProductCate.Size = new System.Drawing.Size(152, 36);
            this.btnFindProductCate.TabIndex = 2;
            this.btnFindProductCate.TextColor = System.Drawing.Color.Black;
            this.btnFindProductCate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindProductCate.Click += new System.EventHandler(this.btnFindProductCate_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private eShopManagementDataSet3 eShopManagementDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private eShopManagementDataSet3TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private eShopManagementDataSet4 eShopManagementDataSet4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private eShopManagementDataSet4TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCateDataGridViewTextBoxColumn1;
        private XanderUI.XUIButton btnFindProductCate;
        private System.Windows.Forms.TextBox textBoxFindProductCate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}