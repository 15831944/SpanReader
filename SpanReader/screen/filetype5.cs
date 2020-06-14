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
    public partial class filetype5 : DevExpress.XtraEditors.XtraUserControl
    {

        private static filetype5 instance;

        public filetype5()
        {
            InitializeComponent();
        }

        public static filetype5 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new filetype5();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.dt_type5;
            gridView1.PopulateColumns();
        }
    }
}
