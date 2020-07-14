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
    public partial class frmFutMargin : DevExpress.XtraEditors.XtraUserControl
    {

        private static frmFutMargin instance;


    
        public static frmFutMargin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmFutMargin();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        public frmFutMargin()
        {
            InitializeComponent();
        }

        private void btnQry1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = util.CSpanData.Instance.FutMargin;
            gridview1.PopulateColumns();
        }
    }
}
