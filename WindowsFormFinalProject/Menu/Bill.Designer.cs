
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
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet1 = new WindowsFormFinalProject.eShopManagementDataSet1();
            this.billTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet1TableAdapters.BillTableAdapter();
            this.billDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagementDataSet2 = new WindowsFormFinalProject.eShopManagementDataSet2();
            this.billDetailTableAdapter = new WindowsFormFinalProject.eShopManagementDataSet2TableAdapters.BillDetailTableAdapter();
            this.textBoxFindBill = new System.Windows.Forms.TextBox();
            this.dataGridDetailBill = new System.Windows.Forms.DataGridView();
            this.btnFindBillDetail = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiButtonExecl = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.dataGridBill.Location = new System.Drawing.Point(67, 55);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.RowHeadersWidth = 51;
            this.dataGridBill.RowTemplate.Height = 24;
            this.dataGridBill.Size = new System.Drawing.Size(410, 308);
            this.dataGridBill.TabIndex = 0;
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
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.eShopManagementDataSet1;
            // 
            // eShopManagementDataSet1
            // 
            this.eShopManagementDataSet1.DataSetName = "eShopManagementDataSet1";
            this.eShopManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // billDetailBindingSource
            // 
            this.billDetailBindingSource.DataMember = "BillDetail";
            this.billDetailBindingSource.DataSource = this.eShopManagementDataSet2;
            // 
            // eShopManagementDataSet2
            // 
            this.eShopManagementDataSet2.DataSetName = "eShopManagementDataSet2";
            this.eShopManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billDetailTableAdapter
            // 
            this.billDetailTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFindBill
            // 
            this.textBoxFindBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFindBill.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindBill.Location = new System.Drawing.Point(486, 72);
            this.textBoxFindBill.Name = "textBoxFindBill";
            this.textBoxFindBill.Size = new System.Drawing.Size(184, 36);
            this.textBoxFindBill.TabIndex = 3;
            this.textBoxFindBill.TextChanged += new System.EventHandler(this.textBoxFindBill_TextChanged);
            // 
            // dataGridDetailBill
            // 
            this.dataGridDetailBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailBill.Location = new System.Drawing.Point(58, 55);
            this.dataGridDetailBill.Name = "dataGridDetailBill";
            this.dataGridDetailBill.RowHeadersWidth = 51;
            this.dataGridDetailBill.RowTemplate.Height = 24;
            this.dataGridDetailBill.Size = new System.Drawing.Size(495, 238);
            this.dataGridDetailBill.TabIndex = 4;
            // 
            // btnFindBillDetail
            // 
            this.btnFindBillDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindBillDetail.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFindBillDetail.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_search_for_love_96_1_;
            this.btnFindBillDetail.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnFindBillDetail.ButtonText = "Search";
            this.btnFindBillDetail.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFindBillDetail.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindBillDetail.CornerRadius = 5;
            this.btnFindBillDetail.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBillDetail.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindBillDetail.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFindBillDetail.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFindBillDetail.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFindBillDetail.Location = new System.Drawing.Point(708, 72);
            this.btnFindBillDetail.Name = "btnFindBillDetail";
            this.btnFindBillDetail.Size = new System.Drawing.Size(125, 36);
            this.btnFindBillDetail.TabIndex = 2;
            this.btnFindBillDetail.TextColor = System.Drawing.Color.Black;
            this.btnFindBillDetail.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFindBillDetail.Click += new System.EventHandler(this.btnFindBillDetail_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find Bill Detail";
            // 
            // xuiButtonExecl
            // 
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
            this.xuiButtonExecl.Location = new System.Drawing.Point(929, 507);
            this.xuiButtonExecl.Name = "xuiButtonExecl";
            this.xuiButtonExecl.Size = new System.Drawing.Size(147, 45);
            this.xuiButtonExecl.TabIndex = 82;
            this.xuiButtonExecl.TextColor = System.Drawing.Color.Black;
            this.xuiButtonExecl.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButtonExecl.Click += new System.EventHandler(this.xuiButtonExecl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxFindBill);
            this.panel1.Controls.Add(this.btnFindBillDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 166);
            this.panel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 410);
            this.panel2.TabIndex = 84;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.xuiButton1);
            this.panel4.Controls.Add(this.dataGridDetailBill);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(523, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 410);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 410);
            this.panel3.TabIndex = 5;
            // 
            // xuiButton1
            // 
            this.xuiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ButtonImage = global::WindowsFormFinalProject.Properties.Resources.icons8_xls_96;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Export";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(406, 318);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(147, 45);
            this.xuiButton1.TabIndex = 82;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiButtonExecl);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private eShopManagementDataSet2 eShopManagementDataSet2;
        private System.Windows.Forms.BindingSource billDetailBindingSource;
        private eShopManagementDataSet2TableAdapters.BillDetailTableAdapter billDetailTableAdapter;
        private XanderUI.XUIButton btnFindBillDetail;
        private System.Windows.Forms.TextBox textBoxFindBill;
        private System.Windows.Forms.DataGridView dataGridDetailBill;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButtonExecl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUIButton xuiButton1;
    }
}