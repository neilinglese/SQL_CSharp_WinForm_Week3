namespace Week3
{
    partial class Form1
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
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAreaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersExampleDataSet = new Week3.SalesOrdersExampleDataSet();
            this.customersTableAdapter = new Week3.SalesOrdersExampleDataSetTableAdapters.CustomersTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersExampleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.custFirstNameDataGridViewTextBoxColumn,
            this.custLastNameDataGridViewTextBoxColumn,
            this.custStreetAddressDataGridViewTextBoxColumn,
            this.custCityDataGridViewTextBoxColumn,
            this.custStateDataGridViewTextBoxColumn,
            this.custZipCodeDataGridViewTextBoxColumn,
            this.custAreaCodeDataGridViewTextBoxColumn,
            this.custPhoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // custFirstNameDataGridViewTextBoxColumn
            // 
            this.custFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.HeaderText = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.Name = "custFirstNameDataGridViewTextBoxColumn";
            // 
            // custLastNameDataGridViewTextBoxColumn
            // 
            this.custLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.HeaderText = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.Name = "custLastNameDataGridViewTextBoxColumn";
            // 
            // custStreetAddressDataGridViewTextBoxColumn
            // 
            this.custStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "CustStreetAddress";
            this.custStreetAddressDataGridViewTextBoxColumn.HeaderText = "CustStreetAddress";
            this.custStreetAddressDataGridViewTextBoxColumn.Name = "custStreetAddressDataGridViewTextBoxColumn";
            // 
            // custCityDataGridViewTextBoxColumn
            // 
            this.custCityDataGridViewTextBoxColumn.DataPropertyName = "CustCity";
            this.custCityDataGridViewTextBoxColumn.HeaderText = "CustCity";
            this.custCityDataGridViewTextBoxColumn.Name = "custCityDataGridViewTextBoxColumn";
            // 
            // custStateDataGridViewTextBoxColumn
            // 
            this.custStateDataGridViewTextBoxColumn.DataPropertyName = "CustState";
            this.custStateDataGridViewTextBoxColumn.HeaderText = "CustState";
            this.custStateDataGridViewTextBoxColumn.Name = "custStateDataGridViewTextBoxColumn";
            // 
            // custZipCodeDataGridViewTextBoxColumn
            // 
            this.custZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CustZipCode";
            this.custZipCodeDataGridViewTextBoxColumn.HeaderText = "CustZipCode";
            this.custZipCodeDataGridViewTextBoxColumn.Name = "custZipCodeDataGridViewTextBoxColumn";
            // 
            // custAreaCodeDataGridViewTextBoxColumn
            // 
            this.custAreaCodeDataGridViewTextBoxColumn.DataPropertyName = "CustAreaCode";
            this.custAreaCodeDataGridViewTextBoxColumn.HeaderText = "CustAreaCode";
            this.custAreaCodeDataGridViewTextBoxColumn.Name = "custAreaCodeDataGridViewTextBoxColumn";
            // 
            // custPhoneNumberDataGridViewTextBoxColumn
            // 
            this.custPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "CustPhoneNumber";
            this.custPhoneNumberDataGridViewTextBoxColumn.HeaderText = "CustPhoneNumber";
            this.custPhoneNumberDataGridViewTextBoxColumn.Name = "custPhoneNumberDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.salesOrdersExampleDataSet;
            // 
            // salesOrdersExampleDataSet
            // 
            this.salesOrdersExampleDataSet.DataSetName = "SalesOrdersExampleDataSet";
            this.salesOrdersExampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(216, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersExampleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesOrdersExampleDataSet salesOrdersExampleDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SalesOrdersExampleDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAreaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}

