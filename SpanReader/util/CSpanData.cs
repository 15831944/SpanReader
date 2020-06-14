using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanReader.util
{
    class CSpanData
    {
        private static CSpanData instance;

        private System.Data.DataSet mDataSet;

        public static CSpanData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CSpanData();

                }
                return instance;
            }
        }

        public DataTable dt_type1;
        public DataTable dt_type2;
        public DataTable dt_type3;
        public DataTable dt_type5;

        public DataTable dt_type81;
        public DataTable dt_type82;

        public DataTable dt_typeB;
        public DataTable dt_typeC;
        public DataTable dt_typeE;
        public DataTable dt_typeP;
        public DataTable dt_typeR;
        public DataTable dt_typeS;
        public DataTable dt_typeZ;


        public CMakeDataTable<_st_type3> mk_type3;
        public CMakeDataTable<_st_type2> mk_type2;
        public CMakeDataTable<_st_type1> mk_type1;
        public CMakeDataTable<_st_type5> mk_type5;
        public CMakeDataTable<_st_type81> mk_type81;
        public CMakeDataTable<_st_type82> mk_type82;
        public CMakeDataTable<_st_typeB> mk_typeB;
        public CMakeDataTable<_st_typeC> mk_typeC;
        public CMakeDataTable<_st_typeE> mk_typeE;
        public CMakeDataTable<_st_typeP> mk_typeP;
        public CMakeDataTable<_st_typeR> mk_typeR;
        public CMakeDataTable<_st_typeS> mk_typeS;
        public CMakeDataTable<_st_typeZ> mk_typeZ;



        /// <summary>
        /// 가공된 Table
        /// </summary>
        public DataTable MrktInfo;

        /// <summary>
        /// SeriesToSeries Table
        /// </summary>
        public DataTable SeriesToSeries;

        public CSpanData()
        {
            mk_type1 = new CMakeDataTable<_st_type1>();
            dt_type1 = mk_type1.DATATABLE;

            mk_type2 = new CMakeDataTable<_st_type2>();
            dt_type2 = mk_type2.DATATABLE;

            mk_type3 = new CMakeDataTable<_st_type3>();
            dt_type3 = mk_type3.DATATABLE;

            mk_type5 = new CMakeDataTable<_st_type5>();
            dt_type5 = mk_type5.DATATABLE;

            mk_type81 = new CMakeDataTable<_st_type81>();
            dt_type81 = mk_type81.DATATABLE;

            mk_type82 = new CMakeDataTable<_st_type82>();
            dt_type82 = mk_type82.DATATABLE;

            mk_typeB = new CMakeDataTable<_st_typeB>();
            dt_typeB = mk_typeB.DATATABLE;

            mk_typeC = new CMakeDataTable<_st_typeC>();
            dt_typeC = mk_typeC.DATATABLE;

            mk_typeE = new CMakeDataTable<_st_typeE>();
            dt_typeE = mk_typeE.DATATABLE;

            mk_typeP = new CMakeDataTable<_st_typeP>();
            dt_typeP = mk_typeP.DATATABLE;

            mk_typeR = new CMakeDataTable<_st_typeR>();
            dt_typeR = mk_typeR.DATATABLE;

            mk_typeS = new CMakeDataTable<_st_typeS>();
            dt_typeS = mk_typeS.DATATABLE;


            mk_typeZ = new CMakeDataTable<_st_typeZ>();
            dt_typeZ = mk_typeZ.DATATABLE;
        }

        /// <summary>
        /// 당사 정보와 매칭된 Commodity_code 데이터를 생성한다.
        /// </summary>
        public void MakeMarketInfo()
        {
            try
            {
                var qry = ((
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a1").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a1"),
                               sContract_Type = type2.Field<string>("sContract_Type_a1"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a1"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a1"),
                           }
                     ).Union(
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a2").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a2"),
                               sContract_Type = type2.Field<string>("sContract_Type_a2"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a2"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a2"),
                           }
                       ).Union(
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a3").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a3"),
                               sContract_Type = type2.Field<string>("sContract_Type_a3"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a3"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a3"),
                           }
                        ).Union(
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a4").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a4"),
                               sContract_Type = type2.Field<string>("sContract_Type_a4"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a4"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a4"),
                           }
                       ).Union(
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a5").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a5"),
                               sContract_Type = type2.Field<string>("sContract_Type_a5"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a5"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a5"),
                           }
                       ).Union(
                           from type2 in CSpanData.Instance.dt_type2.AsEnumerable()
                           where type2.Field<string>("sCommodity_Code_a6").Trim() != ""
                           select new
                           {
                               sExchange_Acronym = type2.Field<string>("sExchange_Acronym"),
                               sCombined_Commodity_Code = type2.Field<string>("sCombined_Commodity_Code"),
                               sRisk_Exponent = type2.Field<string>("sRisk_Exponent"),
                               sPerform_Currency_ISO_Code = type2.Field<string>("sPerform_Currency_ISO_Code"),
                               sPerform_Currency_Code = type2.Field<string>("sPerform_Currency_Code"),
                               sOption_Margin_Style = type2.Field<string>("sOption_Margin_Style"),
                               sLimit_Option_Value_Net_Flag = type2.Field<string>("sLimit_Option_Value_Net_Flag"),
                               sCombination_Margining_Flag = type2.Field<string>("sCombination_Margining_Flag"),
                               sCommodity_Code = type2.Field<string>("sCommodity_Code_a6"),
                               sContract_Type = type2.Field<string>("sContract_Type_a6"),
                               sRisk_Array_Decimal_Locator = type2.Field<string>("sRisk_Array_Decimal_Locator_a6"),
                               sRisk_Array_Decimal_Sign = type2.Field<string>("sRisk_Array_Decimal_Sign_a6"),
                           }
                       )).ToList();


                DataTable tmp1 = CUtil.LinqQueryToDataTable(qry);

                DataTable minfo = CUtil.GetMrktInfo();

                var qry2 = (from data in tmp1.AsEnumerable()
                            join info in minfo.AsEnumerable() on new
                            {
                                sExchange_Acronym = data.Field<string>("sExchange_Acronym"),
                                sCommodity_Code = data.Field<string>("sCommodity_Code"),
                                sContract_Type = data.Field<string>("sContract_Type")
                            }
                            equals new
                            {
                                sExchange_Acronym = info.Field<string>("sExchange_Acronym").PadRight(3),
                                sCommodity_Code = info.Field<string>("sCommodity_Code").PadRight(10),
                                sContract_Type = info.Field<string>("sContract_Type").PadRight(3)

                            }
                            select new
                            {
                                EXCH_CD = info.Field<string>("EXCH_CD"),
                                sExchange_Acronym = data.Field<string>("sExchange_Acronym"),
                                sCombined_Commodity_Code = data.Field<string>("sCombined_Commodity_Code"),
                                sCommodity_Code = data.Field<string>("sCommodity_Code"),
                                MRKT_CD = info.Field<string>("MRKT_CD"),
                                sContract_Type = data.Field<string>("sContract_Type"),
                                sRisk_Exponent = data.Field<string>("sRisk_Exponent"),
                                sPerform_Currency_ISO_Code = data.Field<string>("sPerform_Currency_ISO_Code"),
                                sPerform_Currency_Code = data.Field<string>("sPerform_Currency_Code"),
                                sOption_Margin_Style = data.Field<string>("sOption_Margin_Style"),
                                sLimit_Option_Value_Net_Flag = data.Field<string>("sLimit_Option_Value_Net_Flag"),
                                sCombination_Margining_Flag = data.Field<string>("sCombination_Margining_Flag"),
                                sRisk_Array_Decimal_Locator = data.Field<string>("sRisk_Array_Decimal_Locator"),
                                sRisk_Array_Decimal_Sign = data.Field<string>("sRisk_Array_Decimal_Sign"),
                            }).ToList();

                DataTable tmp2 = CUtil.LinqQueryToDataTable(qry2);

                MrktInfo = tmp2;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 당사기준 SeriesToSeries를 만든다.
        /// </summary>
        public void MakeSeriesToSeries()
        {
            try
            {
                var qry = (from typeE in CSpanData.Instance.dt_typeE.AsEnumerable()
                          join info in CSpanData.instance.MrktInfo.AsEnumerable() on new
                          {
                              sCombined_Commodity_Code = typeE.Field<string>("sCombined_Commodity_Code")
                          }
                          equals new
                          {
                              sCombined_Commodity_Code = info.Field<string>("sCombined_Commodity_Code")
                          }
                          select new
                          {
                              EXCH_CD = info.Field<string>("EXCH_CD"),
                              sExchange_Acronym = info.Field<string>("sExchange_Acronym"),
                              sCombined_Commodity_Code = typeE.Field<string>("sCombined_Commodity_Code"),
                              sCommodity_Code = info.Field<string>("sCommodity_Code"),
                              MRKT_CD = info.Field<string>("MRKT_CD"),
                              sSpread_Priority = typeE.Field<string>("sSpread_Priority"),
                              sCharge_Rate = typeE.Field<string>("sCharge_Rate"),
                              
                              sLeg1_Contract_Month = typeE.Field<string>("sLeg1_Contract_Month"),
                              sLeg1_Rem_Part_of_Contract_Period = typeE.Field<string>("sLeg1_Rem_Part_of_Contract_Period"),
                              sLeg1_Delta_Per_Spread_Ratio = typeE.Field<string>("sLeg1_Delta_Per_Spread_Ratio"),
                              sLeg1_Market_Side = typeE.Field<string>("sLeg1_Market_Side"),

                              sLeg2_Contract_Month = typeE.Field<string>("sLeg2_Contract_Month"),
                              sLeg2_Rem_Part_of_Contract_Period = typeE.Field<string>("sLeg2_Rem_Part_of_Contract_Period"),
                              sLeg2_Delta_Per_Spread_Ratio = typeE.Field<string>("sLeg2_Delta_Per_Spread_Ratio"),
                              sLeg2_Market_Side = typeE.Field<string>("sLeg2_Market_Side"),

                              sLeg3_Contract_Month = typeE.Field<string>("sLeg3_Contract_Month"),
                              sLeg3_Rem_Part_of_Contract_Period = typeE.Field<string>("sLeg3_Rem_Part_of_Contract_Period"),
                              sLeg3_Delta_Per_Spread_Ratio = typeE.Field<string>("sLeg3_Delta_Per_Spread_Ratio"),
                              sLeg3_Market_Side = typeE.Field<string>("sLeg3_Market_Side"),

                              sLeg4_Contract_Month = typeE.Field<string>("sLeg4_Contract_Month"),
                              sLeg4_Rem_Part_of_Contract_Period = typeE.Field<string>("sLeg4_Rem_Part_of_Contract_Period"),
                              sLeg4_Delta_Per_Spread_Ratio = typeE.Field<string>("sLeg4_Delta_Per_Spread_Ratio"),
                              sLeg4_Market_Side = typeE.Field<string>("sLeg4_Market_Side"),
                          }).ToList();

                DataTable tmp1 = CUtil.LinqQueryToDataTable(qry);
                SeriesToSeries = tmp1;
             }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
    }
           


}
