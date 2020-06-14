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
    public partial class mkSeriesToSeries : DevExpress.XtraEditors.XtraUserControl
    {

        private static mkSeriesToSeries instance;


        public mkSeriesToSeries()
        {
            InitializeComponent();
        }

        public static mkSeriesToSeries Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new mkSeriesToSeries();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = CSpanData.Instance.SeriesToSeries;
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.PopulateColumns();
            //gridView1.BeginDataUpdate();
            //try
            //{
            //    gridView1.ClearSorting();
            //    gridView1.Columns["EXCH_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["sExchange_Acronym"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["sCombined_Commodity_Code"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["sCommodity_Code"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //    gridView1.Columns["MRKT_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //}
            //finally
            //{
            //    gridView1.EndDataUpdate();
            //}
        }
    }
}
