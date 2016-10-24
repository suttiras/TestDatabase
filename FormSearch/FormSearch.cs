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

namespace FormSearch
{
    public partial class FormSearch : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;

        public FormSearch()
        {
            InitializeComponent();
            //cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=SANDRA-VAIO\\SQLEXPRESS";
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(textBoxEmpNo.Text);
            if(ds.Tables["employees"].Rows.Contains(empno) == true)
            {
                DataRow row;
                row = ds.Tables["employees"].Rows.Find(empno);
                textBoxEmpName.Text = row["ename"].ToString();
                textBoxSalary.Text = row["salary"].ToString();
                textBoxHireDate.Text = row["hiredate"].ToString();
            }
            else
            {
                MessageBox.Show("Record doesn't exist.", "Error");
                textBoxEmpName.Clear();
                textBoxSalary.Clear();
                textBoxHireDate.Clear();
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=SANDRA-VAIO\\SQLEXPRESS");
            da = new SqlDataAdapter("Select * from Employees", cn);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "employees");
            ds.Tables["employees"].Constraints.Add("Empno_PK", ds.Tables["employees"].Columns["empno"], true);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(textBoxEmpNo.Text);
            DataRow row;
            row = ds.Tables["employees"].Rows.Find(eno);
            row.BeginEdit();
            row["Ename"] = textBoxEmpName.Text;
            row["Salary"] = textBoxSalary.Text;
            row.EndEdit();
            da.Update(ds.Tables["employees"]);
            MessageBox.Show("Employee Record Updated.", "Employee Update Success!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int eno = int.Parse(textBoxEmpNo.Text);
                ds.Tables["employees"].Rows.Find(eno).Delete();
                da.Update(ds.Tables["employees"]);
                MessageBox.Show("Employee Record Deleted.", "Employee Delete Success!");
                textBoxEmpName.Clear();
                textBoxSalary.Clear();
                textBoxEmpNo.Clear();
                textBoxHireDate.Clear();
            }
        }
    }
}
