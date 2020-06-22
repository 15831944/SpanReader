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

namespace SpanReader.Mscreen
{
    /// <summary>
    /// TYPE P 품목 정보를 가지고 있다 
    /// </summary>
    public partial class mTypeP : DevExpress.XtraEditors.XtraUserControl
    {

        private static mTypeP instance;

        public mTypeP()
        {
            InitializeComponent();
        }

        public static mTypeP Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new mTypeP();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.mFileP;
            gridView1.PopulateColumns();
        }
    }
}
