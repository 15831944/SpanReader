using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpanReader.util;

namespace SpanReader.screen
{
    public partial class fileTypeB : DevExpress.XtraEditors.XtraUserControl
    {
        private static fileTypeB instance;

        public fileTypeB()
        {
            InitializeComponent();
        }

        public static fileTypeB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new fileTypeB();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.dt_typeB;
            gridView1.PopulateColumns();
        }
    }
}
