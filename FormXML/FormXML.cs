using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormXML
{
    public partial class FormXML : Form
    {
        public FormXML()
        {
            InitializeComponent();
        }

        private void FormXML_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\Users\Sandra\Documents\Visual Studio 2013\Projects\TestDatabase\FormXML\Books.xml");
            dataGridViewXML.DataSource = ds.Tables[0];
        }
    }
}
