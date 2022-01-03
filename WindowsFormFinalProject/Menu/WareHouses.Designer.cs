
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.xuiButtonExecl = new XanderUI.XUIButton();
            this.btnWareClear = new System.Windows.Forms.Button();
            this.btnWareDelete = new System.Windows.Forms.Button();
            this.btnWareUpdate = new System.Windows.Forms.Button();
            this.btnWareAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 378);
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
            this.prdEmID.Location = new System.Drawing.Point(30, 372);
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
            this.label4.Location = new System.Drawing.Point(69, 329);
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
            this.prdCateName.Location = new System.Drawing.Point(30, 323);
            this.prdCateName.Margin = new System.Windows.Forms.Padding(4);
            this.prdCateName.Name = "prdCateName";
            this.prdCateName.Size = new System.Drawing.Size(184, 29);
            this.prdCateName.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 282);
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
            this.label6.Location = new System.Drawing.Point(44, 234);
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
            this.prdPriceOut.Location = new System.Drawing.Point(30, 276);
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
            this.prdPriceIn.Location = new System.Drawing.Point(30, 228);
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
            this.label3.Location = new System.Drawing.Point(90, 186);
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
            this.label2.Location = new System.Drawing.Point(37, 140);
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
            this.prdQuantity.Location = new System.Drawing.Point(30, 180);
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
            this.prdName.Location = new System.Drawing.Point(30, 134);
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
            this.dataGridView1.Location = new System.Drawing.Point(44, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 394);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 576);
            this.panel1.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.xuiButtonExecl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(474, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 576);
            this.panel2.TabIndex = 83;
            // 
            // prdID
            // 
            this.prdID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdID.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdID.Location = new System.Drawing.Point(30, 85);
            this.prdID.Margin = new System.Windows.Forms.Padding(4);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(184, 29);
            this.prdID.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "ID Product";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 576);
            this.panel3.TabIndex = 80;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.prdID);
            this.panel4.Controls.Add(this.prdEmID);
            this.panel4.Controls.Add(this.prdCateName);
            this.panel4.Controls.Add(this.btnWareClear);
            this.panel4.Controls.Add(this.btnWareDelete);
            this.panel4.Controls.Add(this.btnWareUpdate);
            this.panel4.Controls.Add(this.btnWareAdd);
            this.panel4.Controls.Add(this.prdPriceOut);
            this.panel4.Controls.Add(this.prdPriceIn);
            this.panel4.Controls.Add(this.prdQuantity);
            this.panel4.Controls.Add(this.prdName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 576);
            this.panel4.TabIndex = 81;
            // 
            // xuiButtonExecl
            // 
            this.xuiButtonExecl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButtonExecl.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButtonExecl.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_xls_96;
            this.xuiButtonExecl.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButtonExecl.ButtonText = "Export";
            this.xuiButtonExecl.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButtonExecl.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonExecl.CornerRadius = 5;
            this.xuiButtonExecl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButtonExecl.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonExecl.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButtonExecl.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButtonExecl.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButtonExecl.Location = new System.Drawing.Point(488, 505);
            this.xuiButtonExecl.Name = "xuiButtonExecl";
            this.xuiButtonExecl.Size = new System.Drawing.Size(147, 45);
            this.xuiButtonExecl.TabIndex = 81;
            this.xuiButtonExecl.TextColor = System.Drawing.Color.Black;
            this.xuiButtonExecl.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonExecl.Click += new System.EventHandler(this.xuiButtonExecl_Click);
            // 
            // btnWareClear
            // 
            this.btnWareClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareClear.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.icons8_clear_formatting_96;
            this.btnWareClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWareClear.Location = new System.Drawing.Point(138, 501);
            this.btnWareClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareClear.Name = "btnWareClear";
            this.btnWareClear.Size = new System.Drawing.Size(76, 49);
            this.btnWareClear.TabIndex = 73;
            this.btnWareClear.UseVisualStyleBackColor = true;
            // 
            // btnWareDelete
            // 
            this.btnWareDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareDelete.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.icons8_delete_96;
            this.btnWareDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWareDelete.Location = new System.Drawing.Point(138, 430);
            this.btnWareDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareDelete.Name = "btnWareDelete";
            this.btnWareDelete.Size = new System.Drawing.Size(76, 49);
            this.btnWareDelete.TabIndex = 72;
            this.btnWareDelete.UseVisualStyleBackColor = true;
            this.btnWareDelete.Click += new System.EventHandler(this.btnWareDelete_Click);
            // 
            // btnWareUpdate
            // 
            this.btnWareUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareUpdate.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.icons8_update_96;
            this.btnWareUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWareUpdate.Location = new System.Drawing.Point(30, 501);
            this.btnWareUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareUpdate.Name = "btnWareUpdate";
            this.btnWareUpdate.Size = new System.Drawing.Size(91, 49);
            this.btnWareUpdate.TabIndex = 71;
            this.btnWareUpdate.UseVisualStyleBackColor = true;
            this.btnWareUpdate.Click += new System.EventHandler(this.btnWareUpdate_Click);
            // 
            // btnWareAdd
            // 
            this.btnWareAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWareAdd.BackColor = System.Drawing.Color.White;
            this.btnWareAdd.BackgroundImage = global::WindowsFormFinalProject.Properties.Resources.icons8_add_96;
            this.btnWareAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWareAdd.Location = new System.Drawing.Point(30, 430);
            this.btnWareAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareAdd.Name = "btnWareAdd";
            this.btnWareAdd.Size = new System.Drawing.Size(88, 49);
            this.btnWareAdd.TabIndex = 70;
            this.btnWareAdd.UseVisualStyleBackColor = false;
            this.btnWareAdd.Click += new System.EventHandler(this.btnWareAdd_Click);
            // 
            // WareHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WareHouses";
            this.Text = "WareHouses";
            this.Load += new System.EventHandler(this.WareHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prdEmID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prdCateName;
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
        private XanderUI.XUIButton xuiButtonExecl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox prdID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}