﻿using System;
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
    public partial class filetype8 : DevExpress.XtraEditors.XtraUserControl
    {
        private static filetype8 instance;

        public filetype8()
        {
            InitializeComponent();
        }

        public static filetype8 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new filetype8();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.dt_type81;
            gridView1.PopulateColumns();

            gridControl2.DataSource = CSpanData.Instance.dt_type82;
            gridView2.PopulateColumns();
        }
    }
}
