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
    public partial class IntraSpread : DevExpress.XtraEditors.XtraUserControl
    {

        private static IntraSpread instance;


        public IntraSpread()
        {
            InitializeComponent();
        }

        public static IntraSpread Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IntraSpread();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.mFileC;
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.PopulateColumns();

            gridControl2.DataSource = CSpanData.Instance.mIntraTierInfo;
            gridView2.OptionsView.AllowCellMerge = true;
            gridView2.PopulateColumns();
        }
    }
}
