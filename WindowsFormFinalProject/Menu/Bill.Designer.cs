
namespace WindowsFormFinalProject.Menu
{
    partial class Bill
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
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.eShopManagementDataSet1 = new WindowsFormFinalProject.eShopManagementDataSet1();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet1TableAdapters.BillTableAdapter();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eShopManagementDataSet2 = new WindowsFormFinalProject.eShopManagementDataSet2();
            this.billDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billDetailTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet2TableAdapters.BillDetailTableAdapter();
            this.prdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBill
            // 
            this.dataGridBill.AutoGenerateColumns = false;
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn,
            this.datePickDataGridViewTextBoxColumn});
            this.dataGridBill.DataSource = this.billBindingSource;
            this.dataGridBill.Location = new System.Drawing.Point(64, 121);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.RowHeadersWidth = 51;
            this.dataGridBill.RowTemplate.Height = 24;
            this.dataGridBill.Size = new System.Drawing.Size(410, 308);
            this.dataGridBill.TabIndex = 0;
            // 
            // eShopManagementDataSet1
            // 
            this.eShopManagementDataSet1.DataSetName = "eShopManagementDataSet1";
            this.eShopManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.eShopManagementDataSet1;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "billID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "billID";
            this.billIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "empID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "empID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // datePickDataGridViewTextBoxColumn
            // 
            this.datePickDataGridViewTextBoxColumn.DataPropertyName = "datePick";
            this.datePickDataGridViewTextBoxColumn.HeaderText = "datePick";
            this.datePickDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datePickDataGridViewTextBoxColumn.Name = "datePickDataGridViewTextBoxColumn";
            this.datePickDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prdIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.billIDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.billDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(521, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // eShopManagementDataSet2
            // 
            this.eShopManagementDataSet2.DataSetName = "eShopManagementDataSet2";
            this.eShopManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billDetailBindingSource
            // 
            this.billDetailBindingSource.DataMember = "BillDetail";
            this.billDetailBindingSource.DataSource = this.eShopManagementDataSet2;
            // 
            // billDetailTableAdapter
            // 
            this.billDetailTableAdapter.ClearBeforeFill = true;
            // 
            // prdIDDataGridViewTextBoxColumn
            // 
            this.prdIDDataGridViewTextBoxColumn.DataPropertyName = "prdID";
            this.prdIDDataGridViewTextBoxColumn.HeaderText = "prdID";
            this.prdIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prdIDDataGridViewTextBoxColumn.Name = "prdIDDataGridViewTextBoxColumn";
            this.prdIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // billIDDataGridViewTextBoxColumn1
            // 
            this.billIDDataGridViewTextBoxColumn1.DataPropertyName = "billID";
            this.billIDDataGridViewTextBoxColumn1.HeaderText = "billID";
            this.billIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.billIDDataGridViewTextBoxColumn1.Name = "billIDDataGridViewTextBoxColumn1";
            this.billIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridBill);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBill;
        private eShopManagementDataSet1 eShopManagementDataSet1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private eShopManagementDataSet1TableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private eShopManagementDataSet2 eShopManagementDataSet2;
        private System.Windows.Forms.BindingSource billDetailBindingSource;
        private eShopManagementDataSet2TableAdapters.BillDetailTableAdapter billDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn1;
    }
}