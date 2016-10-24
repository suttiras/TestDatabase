using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormExcel
{
    public partial class FormExcel : Form
    {
        public FormExcel()
        {
            InitializeComponent();
        }

        private void FormExcel_Load(object sender, EventArgs e)
        {
            string cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sandra\Documents\Visual Studio 2013\Projects\TestDatabase\FormExcel\students.xlsx;
                            Extended Properties='Excel 12.0 Xml; HDR=YES'";
            OleDbConnection cn = new OleDbConnection(cs);
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Grades");
            dataGridViewExcel.DataSource = ds.Tables[0];
        }
    }
}
