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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

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

            gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;

            GridGroupSummaryItem array1 = new GridGroupSummaryItem();
            array1.FieldName = "sArray_1_Value";
            array1.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array1.ShowInGroupColumnFooter = gridView1.Columns["sArray_1_Value"];

            GridGroupSummaryItem array2 = new GridGroupSummaryItem();
            array2.FieldName = "sArray_2_Value";
            array2.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array2.ShowInGroupColumnFooter = gridView1.Columns["sArray_2_Value"];


            GridGroupSummaryItem array3 = new GridGroupSummaryItem();
            array3.FieldName = "sArray_3_Value";
            array3.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array3.ShowInGroupColumnFooter = gridView1.Columns["sArray_3_Value"];

            GridGroupSummaryItem array4 = new GridGroupSummaryItem();
            array4.FieldName = "sArray_4_Value";
            array4.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array4.ShowInGroupColumnFooter = gridView1.Columns["sArray_4_Value"];


            GridGroupSummaryItem array5 = new GridGroupSummaryItem();
            array5.FieldName = "sArray_5_Value";
            array5.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array5.ShowInGroupColumnFooter = gridView1.Columns["sArray_5_Value"];


            GridGroupSummaryItem array6 = new GridGroupSummaryItem();
            array6.FieldName = "sArray_6_Value";
            array6.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array6.ShowInGroupColumnFooter = gridView1.Columns["sArray_6_Value"];


            GridGroupSummaryItem array7 = new GridGroupSummaryItem();
            array7.FieldName = "sArray_7_Value";
            array7.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array7.ShowInGroupColumnFooter = gridView1.Columns["sArray_7_Value"];


            GridGroupSummaryItem array8 = new GridGroupSummaryItem();
            array8.FieldName = "sArray_8_Value";
            array8.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array8.ShowInGroupColumnFooter = gridView1.Columns["sArray_8_Value"];


            GridGroupSummaryItem array9 = new GridGroupSummaryItem();
            array9.FieldName = "sArray_9_Value";
            array9.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array9.ShowInGroupColumnFooter = gridView1.Columns["sArray_9_Value"];


            GridGroupSummaryItem array10 = new GridGroupSummaryItem();
            array10.FieldName = "sArray_10_Value";
            array10.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array10.ShowInGroupColumnFooter = gridView1.Columns["sArray_10_Value"];


            GridGroupSummaryItem array11 = new GridGroupSummaryItem();
            array11.FieldName = "sArray_11_Value";
            array11.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array11.ShowInGroupColumnFooter = gridView1.Columns["sArray_11_Value"];


            GridGroupSummaryItem array12 = new GridGroupSummaryItem();
            array12.FieldName = "sArray_12_Value";
            array12.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array12.ShowInGroupColumnFooter = gridView1.Columns["sArray_12_Value"];


            GridGroupSummaryItem array13 = new GridGroupSummaryItem();
            array13.FieldName = "sArray_13_Value";
            array13.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array13.ShowInGroupColumnFooter = gridView1.Columns["sArray_13_Value"];


            GridGroupSummaryItem array14 = new GridGroupSummaryItem();
            array14.FieldName = "sArray_14_Value";
            array14.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array14.ShowInGroupColumnFooter = gridView1.Columns["sArray_14_Value"];


            GridGroupSummaryItem array15 = new GridGroupSummaryItem();
            array15.FieldName = "sArray_15_Value";
            array15.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array15.ShowInGroupColumnFooter = gridView1.Columns["sArray_15_Value"];


            GridGroupSummaryItem array16 = new GridGroupSummaryItem();
            array16.FieldName = "sArray_16_Value";
            array16.SummaryType = DevExpress.Data.SummaryItemType.Max;
            array16.ShowInGroupColumnFooter = gridView1.Columns["sArray_16_Value"];

            gridView1.GroupSummary.Add(array1);
            gridView1.GroupSummary.Add(array2);
            gridView1.GroupSummary.Add(array3);
            gridView1.GroupSummary.Add(array4);
            gridView1.GroupSummary.Add(array5);
            gridView1.GroupSummary.Add(array6);
            gridView1.GroupSummary.Add(array7);
            gridView1.GroupSummary.Add(array8);
            gridView1.GroupSummary.Add(array9);
            gridView1.GroupSummary.Add(array10);
            gridView1.GroupSummary.Add(array11);
            gridView1.GroupSummary.Add(array12);
            gridView1.GroupSummary.Add(array13);
            gridView1.GroupSummary.Add(array14);
            gridView1.GroupSummary.Add(array15);
            gridView1.GroupSummary.Add(array16);

            //gridView1.GetGroupSummaryValues
            gridView1.PopulateColumns();
        }

        private void gridControl1_DefaultViewChanged(object sender, EventArgs e)
        {
            //foreach (DataRow item in gridView1.EndGrouping)
            //{

            //}

            //gridView1.IsGroupRow()
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
         
        }
    }
}
