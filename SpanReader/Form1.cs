using SpanReader.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CMakeDataTable<_st_type1> mkTable = new CMakeDataTable<_st_type1>();
            DataTable dt = mkTable.DATATABLE;

            ///

        }
    }
}
