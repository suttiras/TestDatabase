using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestDatabase
{
    public partial class FormAddRecord : Form
    {
        public FormAddRecord()
        {
            InitializeComponent();
        }

        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=SANDRA-VAIO\\SQLEXPRESS";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);
            DataRow row;
            row = ds.Tables[0].NewRow();
            row["Empno"] = txtEmpno.Text;
            row["Ename"] = txtEname.Text;
            row["Salary"] = txtSalary.Text;
            row["Hiredate"] = dtpHireDate.Value;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Employee record added.", this.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
