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
    public partial class mMrktInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private static mMrktInfo instance;


        public mMrktInfo()
        {
            InitializeComponent();
        }

        public static mMrktInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new mMrktInfo();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var qry = ((
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a1").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a1"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a1"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a1"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a1"),
            //                }
            //          ).Union(
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a2").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a2"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a2"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a2"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a2"),
            //                }
            //            ).Union(
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a3").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a3"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a3"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a3"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a3"),
            //                }
            //             ).Union(
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a4").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a4"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a4"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a4"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a4"),
            //                }
            //            ).Union(
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a5").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a5"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a5"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a5"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a5"),
            //                }
            //            ).Union(
            //                from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
            //                where type2.Field<string>("sCommodity_Code_a6").Trim() != ""
            //                select new
            //                {
            //                    sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
            //                    sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
            //                    sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
            //                    sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
            //                    sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
            //                    sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
            //                    sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                    sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
            //                    sCommodity_Code = type2.Field<string>("sCommodity_Code_a6"),
            //                    sContract_Type = type2.Field<string>("sContract_Type_a6"),
            //                    sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a6"),
            //                    sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a6"),
            //                }
            //            )).ToList();


            //DataTable tmp1 = CUtil.LinqQueryToDataTable(qry);

            //DataTable minfo = CUtil.GetMrktInfo();

            //var qry2 = (from data in tmp1.AsEnumerable()
            //            join info in minfo.AsEnumerable() on new
            //            {
            //                sExchange_Acronym = data.Field<string>("sExchange_Acronym"),
            //                sCommodity_Code = data.Field<string>("sCommodity_Code"),
            //                sContract_Type = data.Field<string>("sContract_Type")
            //            }
            //            equals new
            //            {
            //                sExchange_Acronym = info.Field<string>("sExchange_Acronym").PadRight(3),
            //                sCommodity_Code = info.Field<string>("sCommodity_Code").PadRight(10),
            //                sContract_Type = info.Field<string>("sContract_Type").PadRight(3)

            //            }
            //            select new
            //            {
            //                sExchange_Acronym = data.Field<string>("sExchange_Acronym"),
            //                sCombined_Commodity_Code = data.Field<string>("sCombined_Commodity_Code"),
            //                sRisk_Exponent = data.Field<string>("sRisk_Exponent"),
            //                sPerform_Currency_ISO_Code = data.Field<string>("sPerform_Currency_ISO_Code"),
            //                sPerform_Currency_Code = data.Field<string>("sPerform_Currency_Code"),
            //                sOption_Margin_Style = data.Field<string>("sOption_Margin_Style"),
            //                sLimit_Option_Value_Net_Flag = data.Field<string>("sLimit_Option_Value_Net_Flag"),
            //                sCombination_Margining_Flag = data.Field<string>("sCombination_Margining_Flag"),
            //                sCommodity_Code = data.Field<string>("sCommodity_Code"),
            //                sContract_Type = data.Field<string>("sContract_Type"),
            //                EXCH_CD = info.Field<string>("EXCH_CD"),
            //                MRKT_CD = info.Field<string>("MRKT_CD"),
            //                sRisk_Array_Decimal_Locator = data.Field<string>("sRisk_Array_Decimal_Locator"),
            //                sRisk_Array_Decimal_Sign = data.Field<string>("sRisk_Array_Decimal_Sign"),
            //            }).ToList();

            //DataTable tmp2 = CUtil.LinqQueryToDataTable(qry2);


            gridControl1.DataSource = CSpanData.Instance.MrktInfo;
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.PopulateColumns();
            gridView1.BeginDataUpdate();
            try
            {
                gridView1.ClearSorting();
                gridView1.Columns["EXCH_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["sExchange_Acronym"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["sCombined_Commodity_Code"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["sCommodity_Code"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["MRKT_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            finally
            {
                gridView1.EndDataUpdate();
            }
            

            
            //gridView1.Columns["sCombined_Commodity_Code"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.false
        }
    }
}
