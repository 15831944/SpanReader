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

namespace SpanReader.Mscreen
{
    public partial class mRiskArray : DevExpress.XtraEditors.XtraUserControl
    {

        private static mRiskArray instance;


        public mRiskArray()
        {
            InitializeComponent();
        }

        public static mRiskArray Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new mRiskArray();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = util.CSpanData.Instance.RiskArray;
            gridView1.PopulateColumns();
        }
    }
}
