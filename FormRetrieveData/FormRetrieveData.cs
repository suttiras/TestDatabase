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

namespace FormRetrieveData
{
    public partial class FormRetrieveData : Form
    {
        public FormRetrieveData()
        {
            InitializeComponent();
        }

        private void FormRetrieveData_Load(object sender, EventArgs e)
        {
            //string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=SANDRA-VAIO\\SQLEXPRESS";
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=SANDRA-VAIO\\SQLEXPRESS";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            dataEmployees.DataSource = ds.Tables[0];
        }


    }
}
