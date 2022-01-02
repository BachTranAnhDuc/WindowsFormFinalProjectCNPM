
namespace WindowsFormFinalProject.Menu
{
    partial class WareHouses
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
            this.label7 = new System.Windows.Forms.Label();
            this.prdEmID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prdCateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prdID = new System.Windows.Forms.TextBox();
            this.btnWareClear = new System.Windows.Forms.Button();
            this.btnWareDelete = new System.Windows.Forms.Button();
            this.btnWareUpdate = new System.Windows.Forms.Button();
            this.btnWareAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prdPriceOut = new System.Windows.Forms.TextBox();
            this.prdPriceIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prdQuantity = new System.Windows.Forms.TextBox();
            this.prdName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet = new WindowsFormFinalProject.eShopManagementDataSet();
            this.wareHouseTableAdapter = new WindowsFormFinalProject.eShopManagementDataSetTableAdapters.wareHouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Employee ID";
            // 
            // prdEmID
            // 
            this.prdEmID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdEmID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdEmID.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdEmID.Location = new System.Drawing.Point(258, 369);
            this.prdEmID.Margin = new System.Windows.Forms.Padding(4);
            this.prdEmID.Name = "prdEmID";
            this.prdEmID.Size = new System.Drawing.Size(184, 29);
            this.prdEmID.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Cate Name";
            // 
            // prdCateName
            // 
            this.prdCateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdCateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdCateName.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdCateName.Location = new System.Drawing.Point(258, 320);
            this.prdCateName.Margin = new System.Windows.Forms.Padding(4);
            this.prdCateName.Name = "prdCateName";
            this.prdCateName.Size = new System.Drawing.Size(184, 29);
            this.prdCateName.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "ID Product";
            // 
            // prdID
            // 
            this.prdID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdID.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdID.Location = new System.Drawing.Point(258, 85);
            this.prdID.Margin = new System.Windows.Forms.Padding(4);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(184, 29);
            this.prdID.TabIndex = 74;
            // 
            // btnWareClear
            // 
            this.btnWareClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareClear.Location = new System.Drawing.Point(366, 497);
            this.btnWareClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareClear.Name = "btnWareClear";
            this.btnWareClear.Size = new System.Drawing.Size(76, 49);
            this.btnWareClear.TabIndex = 73;
            this.btnWareClear.Text = "Clear";
            this.btnWareClear.UseVisualStyleBackColor = true;
            // 
            // btnWareDelete
            // 
            this.btnWareDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareDelete.Location = new System.Drawing.Point(366, 426);
            this.btnWareDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareDelete.Name = "btnWareDelete";
            this.btnWareDelete.Size = new System.Drawing.Size(76, 49);
            this.btnWareDelete.TabIndex = 72;
            this.btnWareDelete.Text = "Delete";
            this.btnWareDelete.UseVisualStyleBackColor = true;
            this.btnWareDelete.Click += new System.EventHandler(this.btnWareDelete_Click);
            // 
            // btnWareUpdate
            // 
            this.btnWareUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareUpdate.Location = new System.Drawing.Point(269, 497);
            this.btnWareUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareUpdate.Name = "btnWareUpdate";
            this.btnWareUpdate.Size = new System.Drawing.Size(80, 49);
            this.btnWareUpdate.TabIndex = 71;
            this.btnWareUpdate.Text = "Update";
            this.btnWareUpdate.UseVisualStyleBackColor = true;
            this.btnWareUpdate.Click += new System.EventHandler(this.btnWareUpdate_Click);
            // 
            // btnWareAdd
            // 
            this.btnWareAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareAdd.Location = new System.Drawing.Point(269, 426);
            this.btnWareAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareAdd.Name = "btnWareAdd";
            this.btnWareAdd.Size = new System.Drawing.Size(77, 49);
            this.btnWareAdd.TabIndex = 70;
            this.btnWareAdd.Text = "Add";
            this.btnWareAdd.UseVisualStyleBackColor = true;
            this.btnWareAdd.Click += new System.EventHandler(this.btnWareAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Sale Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "Goods receipt";
            // 
            // prdPriceOut
            // 
            this.prdPriceOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPriceOut.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdPriceOut.Location = new System.Drawing.Point(258, 273);
            this.prdPriceOut.Margin = new System.Windows.Forms.Padding(4);
            this.prdPriceOut.Name = "prdPriceOut";
            this.prdPriceOut.Size = new System.Drawing.Size(184, 29);
            this.prdPriceOut.TabIndex = 67;
            // 
            // prdPriceIn
            // 
            this.prdPriceIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPriceIn.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdPriceIn.Location = new System.Drawing.Point(258, 225);
            this.prdPriceIn.Margin = new System.Windows.Forms.Padding(4);
            this.prdPriceIn.Name = "prdPriceIn";
            this.prdPriceIn.Size = new System.Drawing.Size(184, 29);
            this.prdPriceIn.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Name Product";
            // 
            // prdQuantity
            // 
            this.prdQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdQuantity.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdQuantity.Location = new System.Drawing.Point(258, 177);
            this.prdQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.prdQuantity.Name = "prdQuantity";
            this.prdQuantity.Size = new System.Drawing.Size(184, 29);
            this.prdQuantity.TabIndex = 63;
            // 
            // prdName
            // 
            this.prdName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdName.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdName.Location = new System.Drawing.Point(258, 131);
            this.prdName.Margin = new System.Windows.Forms.Padding(4);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(184, 29);
            this.prdName.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceInDataGridViewTextBoxColumn,
            this.priceOutDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wareHouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(515, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 390);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceInDataGridViewTextBoxColumn
            // 
            this.priceInDataGridViewTextBoxColumn.DataPropertyName = "priceIn";
            this.priceInDataGridViewTextBoxColumn.HeaderText = "priceIn";
            this.priceInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceInDataGridViewTextBoxColumn.Name = "priceInDataGridViewTextBoxColumn";
            this.priceInDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceOutDataGridViewTextBoxColumn
            // 
            this.priceOutDataGridViewTextBoxColumn.DataPropertyName = "priceOut";
            this.priceOutDataGridViewTextBoxColumn.HeaderText = "priceOut";
            this.priceOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceOutDataGridViewTextBoxColumn.Name = "priceOutDataGridViewTextBoxColumn";
            this.priceOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "wareHouse";
            this.wareHouseBindingSource.DataSource = this.eShopManagementDataSet;
            // 
            // eShopManagementDataSet
            // 
            this.eShopManagementDataSet.DataSetName = "eShopManagementDataSet";
            this.eShopManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // WareHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdEmID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prdCateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prdID);
            this.Controls.Add(this.btnWareClear);
            this.Controls.Add(this.btnWareDelete);
            this.Controls.Add(this.btnWareUpdate);
            this.Controls.Add(this.btnWareAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prdPriceOut);
            this.Controls.Add(this.prdPriceIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prdQuantity);
            this.Controls.Add(this.prdName);
            this.Name = "WareHouses";
            this.Text = "WareHouses";
            this.Load += new System.EventHandler(this.WareHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prdEmID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prdCateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prdID;
        private System.Windows.Forms.Button btnWareClear;
        private System.Windows.Forms.Button btnWareDelete;
        private System.Windows.Forms.Button btnWareUpdate;
        private System.Windows.Forms.Button btnWareAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prdPriceOut;
        private System.Windows.Forms.TextBox prdPriceIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prdQuantity;
        private System.Windows.Forms.TextBox prdName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private eShopManagementDataSet eShopManagementDataSet;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private eShopManagementDataSetTableAdapters.wareHouseTableAdapter wareHouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
    }
}