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

        List<string> fields = new List<string>();
       

        public mkSeriesToSeries()
        {
            InitializeComponent();

            fields.Add("EXCH_CD");
            fields.Add("sExchange_Acronym");
            fields.Add("sCombined_Commodity_Code");
            fields.Add("sCommodity_Code");
            fields.Add("MRKT_CD");
            fields.Add("sSpread_Priority");
            fields.Add("sCharge_Rate");
            fields.Add("sNumber_of_Legs");
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



        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
           
            if (fields.Exists(x => x.Equals(e.Column.FieldName.ToString())) )
            {
                var dr1 = gridView1.GetDataRow(e.RowHandle1);
                var dr2 = gridView1.GetDataRow(e.RowHandle2);

                e.Merge = dr1[e.Column.FieldName].ToString().Equals(dr2[e.Column.FieldName].ToString());
            }
            else
            {
                e.Merge = false;
            }

            e.Handled = true;
        }
    }
}
