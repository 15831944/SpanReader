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
    public partial class InterSpread : DevExpress.XtraEditors.XtraUserControl
    {

        private static InterSpread instance;

        public InterSpread()
        {
            InitializeComponent();
        }

        public static InterSpread Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InterSpread();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.mInterTierInfo;
            gridView1.PopulateColumns();
        }
    }
}
