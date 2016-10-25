using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDisplayData2
{
    public partial class FormDisplayData : Form
    {
        public FormDisplayData()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDisplay);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDisplay.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSetDisplay.Employees);

        }
    }
}
