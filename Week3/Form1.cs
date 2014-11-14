using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'salesOrdersExampleDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesOrdersExampleDataSet.Customers);
            updateTable();
      

 
        }
        private void updateTable()
        {
            this.customersTableAdapter.Update(this.salesOrdersExampleDataSet.Customers);
            label1.Text = "Total Records: " + (dataGridView1.Rows.Count - 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateTable();

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                updateTable();
            }
            else
                return;
        }
    }
}
