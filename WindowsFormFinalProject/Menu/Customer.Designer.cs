
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
            this.eShopManagementDataSet5 = new WindowsFormFinalProject.eShopManagementDataSet5();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet5TableAdapters.CustomerTableAdapter();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordsDataGridViewTextBoxColumn,
            this.nameCusDataGridViewTextBoxColumn,
            this.addressCusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(242, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // eShopManagementDataSet5
            // 
            this.eShopManagementDataSet5.DataSetName = "eShopManagementDataSet5";
            this.eShopManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.eShopManagementDataSet5;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
    }
}