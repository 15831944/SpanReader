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
        public DataTable dt_type6;

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
        public CMakeDataTable<_st_type6> mk_type6;
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


        public DataTable RiskArray;

        //선물 계약당 증거금
        public DataTable FutMargin;

        public DataTable mFileP;

        public DataTable mFileC;

        /// <summary>
        /// 가공된 파일type3
        /// </summary>
        public DataTable mIntraTierInfo; ///

        /// types
        public DataTable mInterTierInfo;

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

            mk_type6 = new CMakeDataTable<_st_type6>();
            dt_type6 = mk_type6.DATATABLE;

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

                DataTable tmp11 = tmp1.Copy();
                tmp11.Columns.Add("sNumber_of_Legs", typeof(string));
                tmp11.Columns.Add("sLeg_Leg_number", typeof(string));
                tmp11.Columns.Add("sLeg_Contract_Month", typeof(string));
                tmp11.Columns.Add("sLeg_Contract_Period", typeof(string));
                tmp11.Columns.Add("sLeg_Delta_Per_Spread_Ratio", typeof(string));
                tmp11.Columns.Add("sLeg_Market_Side", typeof(string));

                DataTable tmp2 = tmp11.Clone();
                

                

                foreach (DataRow item in tmp11.Rows)
                {
                    int nCnt = 2;
                    if (item["sLeg4_Market_Side"].ToString().Trim() != "" )
                    {
                        nCnt = 4;
                    }
                    else if (item["sLeg3_Market_Side"].ToString().Trim() != "")
                    {
                        nCnt = 3;
                    }

                    for (int i = 0; i < nCnt; i++)
                    {
                        string contract_month = string.Format("sLeg{0}_Contract_Month", i+1);
                        string contract_Period= string.Format("sLeg{0}_Rem_Part_of_Contract_Period", i + 1);
                        string spred_ratio = string.Format("sLeg{0}_Delta_Per_Spread_Ratio", i + 1);
                        string market_side = string.Format("sLeg{0}_Market_Side", i + 1);

                        
                        item["sNumber_of_Legs"] = nCnt.ToString();
                        item["sLeg_Leg_number"] = string.Format("{0}", i + 1);
                        item["sLeg_Contract_Month"] = item[contract_month];
                        item["sLeg_Contract_Period"] = item[contract_Period];
                        item["sLeg_Delta_Per_Spread_Ratio"] = item[spred_ratio];
                        item["sLeg_Market_Side"] = item[market_side];

                        tmp2.ImportRow(item);
                    }
                }

                var qrySeries = (
                                    from info in tmp2.AsEnumerable()
                                    select new
                                    {
                                        EXCH_CD = info.Field<string>("EXCH_CD"),
                                        sExchange_Acronym = info.Field<string>("sExchange_Acronym"),
                                        sCombined_Commodity_Code = info.Field<string>("sCombined_Commodity_Code"),
                                        sCommodity_Code = info.Field<string>("sCommodity_Code"),
                                        MRKT_CD = info.Field<string>("MRKT_CD"),
                                        sSpread_Priority = info.Field<string>("sSpread_Priority"),
                                        sCharge_Rate = info.Field<string>("sCharge_Rate"),
                                        sNumber_of_Legs = info.Field<string>("sNumber_of_Legs"),
                                        sLeg_Leg_number = info.Field<string>("sLeg_Leg_number"),
                                        sLeg_Contract_Month = info.Field<string>("sLeg_Contract_Month"),
                                        sLeg_Contract_Period = info.Field<string>("sLeg_Contract_Period"),
                                        sLeg_Delta_Per_Spread_Ratio = info.Field<string>("sLeg_Delta_Per_Spread_Ratio"),
                                        sLeg_Market_Side = info.Field<string>("sLeg_Market_Side"),
                                    }
                                ).ToList();



                SeriesToSeries = CUtil.LinqQueryToDataTable(qrySeries);
             }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// fileP는 Span File의 품목 정보에 해당
        /// 거래금액, 및 정산가의 소수점 정보, 품목명 등이 들어있음 
        /// </summary>
        public void MakefileP_modify()
        {
            try
            {

                DataTable minfo = CUtil.GetMrktInfo();

                var qry = (from typeP in CSpanData.Instance.dt_typeP.AsEnumerable()
                           join info in minfo.AsEnumerable() on new
                           {
                               sExchange_Acronym = typeP.Field<string>("sExchange_Acronym"),
                               sCommodity_Code = typeP.Field<string>("sCommodity_Code"),
                               sContract_Type = typeP.Field<string>("sProduct_Type_Code")
                           }
                           equals new
                           {
                               sExchange_Acronym = info.Field<string>("sExchange_Acronym").PadRight(3),
                               sCommodity_Code = info.Field<string>("sCommodity_Code").PadRight(10),
                               sContract_Type = info.Field<string>("sContract_Type").PadRight(3)
                           }
                           select new
                           {
                               sExchange_Acronym = typeP.Field<string>("sExchange_Acronym"),
                               EXCH_CD = info.Field<string>("EXCH_CD"),
                               sCommodity_Code = typeP.Field<string>("sCommodity_Code"),
                               MRKT_CD = info.Field<string>("MRKT_CD"),
                               sProduct_Type_Code = typeP.Field<string>("sProduct_Type_Code"),
                               sProduct_Long_Name = typeP.Field<string>("sProduct_Long_Name"),
                               sSettlement_Price_Decimal = typeP.Field<string>("sSettlement_Price_Decimal"),
                               sStrike_Price_Decimal = typeP.Field<string>("sStrike_Price_Decimal"),
                               sSettlement_Price_Alignment = typeP.Field<string>("sSettlement_Price_Alignment"),
                               sStrike_Price_Alignment = typeP.Field<string>("sStrike_Price_Alignment"),
                               sContract_Value_Factor = typeP.Field<string>("sContract_Value_Factor"),
                               sStandard_Cabinet_Opt_Value = typeP.Field<string>("sStandard_Cabinet_Opt_Value"),
                               sQuoted_Position_Quantity = typeP.Field<string>("sQuoted_Position_Quantity"),
                               sSettle_Currency_ISO_Code = typeP.Field<string>("sSettle_Currency_ISO_Code"),
                               sSettle_Currency_One_Code = typeP.Field<string>("sSettle_Currency_One_Code"),
                               sPrice_Quotation_Method = typeP.Field<string>("sPrice_Quotation_Method"),
                               sContract_Value_Factor_Sign = typeP.Field<string>("sContract_Value_Factor_Sign"),
                               sContract_Value_Factor_Expo = typeP.Field<string>("sContract_Value_Factor_Expo"),
                               sExercise_Style = typeP.Field<string>("sExercise_Style"),
                               sPosition_Product_Indicator = typeP.Field<string>("sPosition_Product_Indicator"),
                               sMoney_Calc_Method = typeP.Field<string>("sMoney_Calc_Method"),
                               sValuation_Method = typeP.Field<string>("sValuation_Method"),
                               sSettlement_Method = typeP.Field<string>("sSettlement_Method"),
                               //sFX_Forward_Products = typeP.Field<string>("sFX_Forward_Products"),
                               //sFX_Pre_Spot_Date = typeP.Field<string>("sFX_Pre_Spot_Date"),
                               //sFX_Pre_Spot_Date_Week_Num = typeP.Field<string>("sFX_Pre_Spot_Date_Week_Num"),
                               //sFX_Forward_Credit_Rate = typeP.Field<string>("sFX_Forward_Credit_Rate"),
                               sEquiv_Pos_Fact = typeP.Field<string>("sEquiv_Pos_Fact"),
                               sEquiv_Pos_Fact_Exp = typeP.Field<string>("sEquiv_Pos_Fact_Exp"),
                               sEquiv_Pos_Fact_Exp_Sign = typeP.Field<string>("sEquiv_Pos_Fact_Exp_Sign"),
                               //sVariable_Tick_Option_Flag = typeP.Field<string>("sVariable_Tick_Option_Flag"),
                               //sFX_Pre_Spot_DatsVariable_Tick_Option_Flage_Week_Num = typeP.Field<string>("sFX_Pre_Spot_Date_Week_Num"),
                               //sPrice_Quot_Currency = typeP.Field<string>("sPrice_Quot_Currency"),
                               //sOption_Money_Condition = typeP.Field<string>("sOption_Money_Condition"),
                               //sOption_Contrary_Instruction = typeP.Field<string>("sOption_Contrary_Instruction")
                           }).ToList();

                DataTable tmp1 = CUtil.LinqQueryToDataTable(qry);
                mFileP = tmp1;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 당사기준 SeriesToSeries를 만든다.
        /// </summary>
        public void MakeRiskArray()
        {
            try
            {
                string tmpStrikeP = "";

                var qry = (from type81 in CSpanData.Instance.dt_type81.AsEnumerable()
                           join type82 in CSpanData.instance.dt_type82.AsEnumerable() on new
                           {    
                                sExchange_Acronym = type81.Field<string>("sExchange_Acronym"),
                                sCommodity_Code = type81.Field<string>("sCommodity_Code"),
                                sUnderlying_Commodity_Code =  type81.Field<string>("sUnderlying_Commodity_Code"),
                                sProduct_Type_Code7 =  type81.Field<string>("sProduct_Type_Code7"),
                                sOption_Right_Code =  type81.Field<string>("sOption_Right_Code"),
                                sFutures_Ccyymm= type81.Field<string>("sFutures_Ccyymm"),
                                sOption_Ccyymm = type81.Field<string>("sOption_Ccyymm"),
                                sOption_Strike_Price = type81.Field<string>("sOption_Strike_Price")
                           }
                           equals new
                           {
                               sExchange_Acronym = type82.Field<string>("sExchange_Acronym"),
                               sCommodity_Code = type82.Field<string>("sCommodity_Code"),
                               sUnderlying_Commodity_Code = type82.Field<string>("sUnderlying_Commodity_Code"),
                               sProduct_Type_Code7 = type82.Field<string>("sProduct_Type_Code7"),
                               sOption_Right_Code = type82.Field<string>("sOption_Right_Code"),
                               sFutures_Ccyymm = type82.Field<string>("sFutures_Ccyymm"),
                               sOption_Ccyymm = type82.Field<string>("sOption_Ccyymm"),
                               sOption_Strike_Price = type82.Field<string>("sOption_Strike_Price")
                           }
                           select new
                           {
                               sExchange_Acronym = type81.Field<string>("sExchange_Acronym"),
                               sCommodity_Code = type81.Field<string>("sCommodity_Code"),
                               sUnderlying_Commodity_Code = type81.Field<string>("sUnderlying_Commodity_Code"),
                               sProduct_Type_Code = type81.Field<string>("sProduct_Type_Code7"),
                               sOption_Right_Code = type81.Field<string>("sOption_Right_Code"),
                               sFutures_Ccyymm = type81.Field<string>("sFutures_Ccyymm"),
                               sOption_Ccyymm = type81.Field<string>("sOption_Ccyymm"),
                               sOption_Strike_Price = type81.Field<string>("sOption_Strike_Price"),
                               sArray_1_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_1_Sign").ToString() , type81.Field<string>("sArray_1_Value").ToString()),
                               sArray_2_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_2_Sign").ToString() , type81.Field<string>("sArray_2_Value").ToString()),
                               sArray_3_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_3_Sign").ToString() , type81.Field<string>("sArray_3_Value").ToString()),
                               sArray_4_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_4_Sign").ToString() , type81.Field<string>("sArray_4_Value").ToString()),
                               sArray_5_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_5_Sign").ToString() , type81.Field<string>("sArray_5_Value").ToString()),
                               sArray_6_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_6_Sign").ToString() , type81.Field<string>("sArray_6_Value").ToString()),
                               sArray_7_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_7_Sign").ToString() , type81.Field<string>("sArray_7_Value").ToString()),
                               sArray_8_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_8_Sign").ToString() , type81.Field<string>("sArray_8_Value").ToString()),
                               sArray_9_Value = CUtil.ConvertArrayValue(type81.Field<string>("sArray_9_Sign").ToString() , type81.Field<string>("sArray_9_Value").ToString()),
                               sArray_10_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_10_Sign").ToString() , type82.Field<string>("sArray_10_Value").ToString()),
                               sArray_11_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_11_Sign").ToString() , type82.Field<string>("sArray_11_Value").ToString()),
                               sArray_12_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_12_Sign").ToString() , type82.Field<string>("sArray_12_Value").ToString()),
                               sArray_13_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_13_Sign").ToString() , type82.Field<string>("sArray_13_Value").ToString()),
                               sArray_14_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_14_Sign").ToString() , type82.Field<string>("sArray_14_Value").ToString()),
                               sArray_15_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_15_Sign").ToString() , type82.Field<string>("sArray_15_Value").ToString()),
                               sArray_16_Value = CUtil.ConvertArrayValue(type82.Field<string>("sArray_16_Sign").ToString() , type82.Field<string>("sArray_16_Value").ToString()),

                               sSpan_Composite_Delta = CUtil.ConvertArrayValue(type82.Field<string>("sSpan_Composite_Delta_Sign").ToString(), type82.Field<string>("sSpan_Composite_Delta").ToString()),
                               sImplied_Volatility = type82.Field<string>("sImplied_Volatility"),
                               sSettlement_Price = CUtil.ConvertArrayValue(type82.Field<string>("sSettlement_Price_Sign").ToString(), type82.Field<string>("sSettlement_Price").ToString()),
                               sStrike_Price_Sign = type82.Field<string>("sStrike_Price_Sign"),
                               sCurrent_Delta = CUtil.ConvertArrayValue(type82.Field<string>("sCurrent_Delta_Sign").ToString(), type82.Field<string>("sCurrent_Delta").ToString()),
                               sCurrent_Delta_Bsns_Day_Flag = type82.Field<string>("sCurrent_Delta_Bsns_Day_Flag"),
                               sStart_Of_Day_Price = type82.Field<string>("sStart_Of_Day_Price"),
                               sStart_Of_Day_Price_Sign = type82.Field<string>("sStart_Of_Day_Price_Sign"),
                               sImplied_Volatility_Exponent = type82.Field<string>("sImplied_Volatility_Exponent"),
                               sImplied_Volatility_Exponent_Sign = type82.Field<string>("sImplied_Volatility_Exponent_Sign")

                               //이후 컬럼은 Data 없음 
                               //sCont_Cont_Val_Fact = type82.Field<string>("sCont_Cont_Val_Fact"),
                               //sCont_Cont_Val_Fact_Exp = type82.Field<string>("sCont_Cont_Val_Fact_Exp"),
                               //sCont_Cont_Val_Fact_Exp_Sign = type82.Field<string>("sCont_Cont_Val_Fact_Exp_Sign"),
                               //sCont_Strike_Val_Fact = type82.Field<string>("sCont_Strike_Val_Fact"),
                               //sCont_Strike_Val_Fact_Exp = type82.Field<string>("sCont_Strike_Val_Fact_Exp"),
                               //sCont_Strike_Val_Fact_Exp_Sign = type82.Field<string>("sCont_Strike_Val_Fact_Exp_Sign")
                            }).ToList();

                DataTable tmp1 = CUtil.LinqQueryToDataTable(qry);

                var qryData = (
                                   from rArray in tmp1.AsEnumerable()
                                   join mrktInfo in mFileP.AsEnumerable() on new
                                   {
                                       sExchange_Acronym = rArray.Field<string>("sExchange_Acronym"),
                                       sCommodity_Code = rArray.Field<string>("sCommodity_Code"),
                                       sContract_Type = rArray.Field<string>("sProduct_Type_Code")
                                   }
                                   equals new
                                   {
                                       sExchange_Acronym = mrktInfo.Field<string>("sExchange_Acronym"),
                                       sCommodity_Code = mrktInfo.Field<string>("sCommodity_Code"),
                                       sContract_Type = mrktInfo.Field<string>("sProduct_Type_Code")
                                   }
                                   select new
                                   {
                                       EXCH_CD = mrktInfo.Field<string>("EXCH_CD"),
                                       MRKT_CD = mrktInfo.Field<string>("MRKT_CD"),
                                       //tmpStrikeP = CUtil.GetStrikePrice(rArray, mrktInfo),//.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sStrike_Price_Sign"), rArray.Field<string>("sOption_Strike_Price"), mrktInfo.Field<string>("sStrike_Price_Decimal"), mrktInfo.Field<string>("sStrike_Price_Alignment"), mrktInfo.Field<string>("sSettlement_Price_Alignment")),

                                       SERIES = CUtil.GetSeries(rArray, mrktInfo),
                                       //SERIES =     CUtil.GetSeries(rArray.Field<string>("sProduct_Type_Code"), mrktInfo.Field<string>("MRKT_CD"), rArray.Field<string>("sFutures_Ccyymm"), rArray.Field<string>("sOption_Ccyymm"), rArray.Field<string>("sOption_Right_Code"), tmpStrikeP),
                                       sExchange_Acronym = rArray.Field<string>("sExchange_Acronym"),
                                       sCommodity_Code = rArray.Field<string>("sCommodity_Code"),
                                       sUnderlying_Commodity_Code = rArray.Field<string>("sUnderlying_Commodity_Code"),
                                       sProduct_Type_Code = rArray.Field<string>("sProduct_Type_Code"),
                                       sOption_Right_Code = rArray.Field<string>("sOption_Right_Code"),
                                       sFutures_Ccyymm = rArray.Field<string>("sFutures_Ccyymm"),
                                       sOption_Ccyymm = rArray.Field<string>("sOption_Ccyymm"),

                                       sOption_Strike_Price = rArray.Field<string>("sOption_Strike_Price"),
                                       Strike_Prie = CUtil.GetStrikePrice(rArray, mrktInfo),//.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sStrike_Price_Sign"), rArray.Field<string>("sOption_Strike_Price"), mrktInfo.Field<string>("sStrike_Price_Decimal"), mrktInfo.Field<string>("sStrike_Price_Alignment"), mrktInfo.Field<string>("sSettlement_Price_Alignment")),

                                       //Strike_Prie = CUtil.GetStrikePrice(rArray.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sStrike_Price_Sign"),  rArray.Field<string>("sOption_Strike_Price"), mrktInfo.Field<string>("sStrike_Price_Decimal"), mrktInfo.Field<string>("sStrike_Price_Alignment"), mrktInfo.Field<string>("sSettlement_Price_Alignment")),

                                       sStrike_Price_Decimal = mrktInfo.Field<string>("sStrike_Price_Decimal"),
                                       sStrike_Price_Sign = rArray.Field<string>("sStrike_Price_Sign"),
                                       sStrike_Price_Alignment = mrktInfo.Field<string>("sStrike_Price_Alignment"),

                                       
                                       sSettlement_Price = rArray.Field<string>("sSettlement_Price"),
                                       sSettlement_Price_Decimal = mrktInfo.Field<string>("sSettlement_Price_Decimal"),
                                       sSettlement_Price_Alignment = mrktInfo.Field<string>("sSettlement_Price_Alignment"),

                                       sArray_1_Value = rArray.Field<string>("sArray_1_Value"),
                                       sArray_2_Value = rArray.Field<string>("sArray_2_Value"),
                                       sArray_3_Value = rArray.Field<string>("sArray_3_Value"),
                                       sArray_4_Value = rArray.Field<string>("sArray_4_Value"),
                                       sArray_5_Value = rArray.Field<string>("sArray_5_Value"),
                                       sArray_6_Value = rArray.Field<string>("sArray_6_Value"),
                                       sArray_7_Value = rArray.Field<string>("sArray_7_Value"),
                                       sArray_8_Value = rArray.Field<string>("sArray_8_Value"),
                                       sArray_9_Value = rArray.Field<string>("sArray_9_Value"),
                                       sArray_10_Value = rArray.Field<string>("sArray_10_Value"),
                                       sArray_11_Value = rArray.Field<string>("sArray_11_Value"),
                                       sArray_12_Value = rArray.Field<string>("sArray_12_Value"),
                                       sArray_13_Value = rArray.Field<string>("sArray_13_Value"),
                                       sArray_14_Value = rArray.Field<string>("sArray_14_Value"),
                                       sArray_15_Value = rArray.Field<string>("sArray_15_Value"),
                                       sArray_16_Value = rArray.Field<string>("sArray_16_Value"),

                                       sSpan_Composite_Delta = rArray.Field<string>("sSpan_Composite_Delta"),
                                       sImplied_Volatility = rArray.Field<string>("sImplied_Volatility"),
                                       
                                       
                                       sCurrent_Delta = rArray.Field<string>("sCurrent_Delta"),
                                       sCurrent_Delta_Bsns_Day_Flag = rArray.Field<string>("sCurrent_Delta_Bsns_Day_Flag"),
                                       sStart_Of_Day_Price = rArray.Field<string>("sStart_Of_Day_Price"),
                                       sStart_Of_Day_Price_Sign = rArray.Field<string>("sStart_Of_Day_Price_Sign"),
                                       sImplied_Volatility_Exponent = rArray.Field<string>("sImplied_Volatility_Exponent"),
                                       sImplied_Volatility_Exponent_Sign = rArray.Field<string>("sImplied_Volatility_Exponent_Sign")
                                   }
                              ).ToList();

                DataTable tmp2 = CUtil.LinqQueryToDataTable(qryData);



                RiskArray = tmp2;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// RiskArray로 부터 계약당 증거금을 찾는다.
        /// </summary>
        public void MakeMarginInfo()
        {
            try
            {
                var qry = (from riskarray in RiskArray.AsEnumerable()
                           where riskarray.Field<string>("sProduct_Type_Code") == "FUT"
                           group riskarray by riskarray.Field<string>("MRKT_CD") into g
                           select new
                           {
                               
                               MRKT_CD = g.Key,
                               ARRAY1 = g.Max(p => p.Field<string>("sArray_1_Value")),
                               ARRAY2 = g.Max(p => p.Field<string>("sArray_2_Value")),
                               ARRAY3 = g.Max(p => p.Field<string>("sArray_3_Value")),
                               ARRAY4 = g.Max(p => p.Field<string>("sArray_4_Value")),
                               ARRAY5 = g.Max(p => p.Field<string>("sArray_5_Value")),
                               ARRAY6 = g.Max(p => p.Field<string>("sArray_6_Value")),
                               ARRAY7 = g.Max(p => p.Field<string>("sArray_7_Value")),
                               ARRAY8 = g.Max(p => p.Field<string>("sArray_8_Value")),
                               ARRAY9 = g.Max(p => p.Field<string>("sArray_9_Value")),
                               ARRAY10 = g.Max(p => p.Field<string>("sArray_10_Value")),
                               ARRAY11 = g.Max(p => p.Field<string>("sArray_11_Value")),
                               ARRAY12 = g.Max(p => p.Field<string>("sArray_12_Value")),
                               ARRAY13 = g.Max(p => p.Field<string>("sArray_13_Value")),
                               ARRAY14 = g.Max(p => p.Field<string>("sArray_14_Value")),
                               ARRAY15 = g.Max(p => p.Field<string>("sArray_15_Value")),
                               ARRAY16 = g.Max(p => p.Field<string>("sArray_16_Value")),

                           }).Distinct();

                DataTable tmpQry = CUtil.LinqQueryToDataTable(qry);
                

                //아직 계약당 증거금은 산출되지 않았다

                var qry2 = from array in tmpQry.AsEnumerable()
                           select new
                           {
                               MRKT_CD = array.Field<string>("MRKT_CD"),
                               MARGIN = CUtil.GetMaxArrayValue(array)
                           };

                DataTable tmpMargin = CUtil.LinqQueryToDataTable(qry2);

                var qry3 = (from arrayList in tmpQry.AsEnumerable()
                            join margin in tmpMargin.AsEnumerable() on new
                            {
                                MRKT_CD = arrayList.Field<string>("MRKT_CD")
                            }
                            equals new
                            {
                                MRKT_CD = margin.Field<string>("MRKT_CD")
                            }
                            select new
                            {
                                MRKT_CD = arrayList.Field<string>("MRKT_CD"),
                                MARGIN = margin.Field<string>("MARGIN"),
                                ARRAY1 = arrayList.Field<string>("ARRAY1"),
                                ARRAY2 = arrayList.Field<string>("ARRAY2"),
                                ARRAY3 = arrayList.Field<string>("ARRAY3"),
                                ARRAY4 = arrayList.Field<string>("ARRAY4"),
                                ARRAY5 = arrayList.Field<string>("ARRAY5"),
                                ARRAY6 = arrayList.Field<string>("ARRAY6"),
                                ARRAY7 = arrayList.Field<string>("ARRAY7"),
                                ARRAY8 = arrayList.Field<string>("ARRAY8"),
                                ARRAY9 = arrayList.Field<string>("ARRAY9"),
                                ARRAY10 = arrayList.Field<string>("ARRAY10"),
                                ARRAY11 = arrayList.Field<string>("ARRAY11"),
                                ARRAY12 = arrayList.Field<string>("ARRAY12"),
                                ARRAY13 = arrayList.Field<string>("ARRAY13"),
                                ARRAY14 = arrayList.Field<string>("ARRAY14"),
                                ARRAY15 = arrayList.Field<string>("ARRAY15"),
                                ARRAY16 = arrayList.Field<string>("ARRAY16")
                            }).ToList();

                FutMargin = CUtil.LinqQueryToDataTable(qry3);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void MakeIntraTierInfo()
        {
            ///Tier Info inter spread
            try
            {
                var qry = (from mrkt in MrktInfo.AsEnumerable()
                           select new
                           {
                               sCombined_Commodity_Code = mrkt.Field<string>("sCombined_Commodity_Code")
                           }).Distinct().ToList();

                DataTable ccd = CUtil.LinqQueryToDataTable(qry);


                ///unique한 정보를 얻는다. 
                var qryTier = (
                                from tier in dt_type3.AsEnumerable()
                                join mrkt in ccd.AsEnumerable() on new
                                {
                                    sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code")
                                }
                                equals new
                                {
                                    sCombined_Commodity_Code = mrkt.Field<string>("sCombined_Commodity_Code")
                                }
                                select tier
                          );

                DataTable tmp1 = qryTier.CopyToDataTable();



                var qryTierInfo = ((
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier1_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sIntracommodity_Spread_Charge_Method_Code = TierInfo.Field<string>("sIntracommodity_Spread_Charge_Method_Code"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier1_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier1_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier1_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier1_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier1_Ending_Day_Week_Code"),

                                        sInitial_to_Maintenance_Ratio_Member = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Member"),
                                        sInitial_to_Maintenance_Ratio_Hedger = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Hedger"),
                                        sInitial_to_Maintenance_Ratio_Speculator = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Speculator")
                                    }
                                  ).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier2_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sIntracommodity_Spread_Charge_Method_Code = TierInfo.Field<string>("sIntracommodity_Spread_Charge_Method_Code"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier2_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier2_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier2_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier2_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier2_Ending_Day_Week_Code"),

                                        sInitial_to_Maintenance_Ratio_Member = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Member"),
                                        sInitial_to_Maintenance_Ratio_Hedger = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Hedger"),
                                        sInitial_to_Maintenance_Ratio_Speculator = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Speculator")
                                    }
                                  ).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier3_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sIntracommodity_Spread_Charge_Method_Code = TierInfo.Field<string>("sIntracommodity_Spread_Charge_Method_Code"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier3_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier3_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier3_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier3_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier3_Ending_Day_Week_Code"),

                                        sInitial_to_Maintenance_Ratio_Member = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Member"),
                                        sInitial_to_Maintenance_Ratio_Hedger = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Hedger"),
                                        sInitial_to_Maintenance_Ratio_Speculator = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Speculator")
                                    }
                                  ).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier4_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sIntracommodity_Spread_Charge_Method_Code = TierInfo.Field<string>("sIntracommodity_Spread_Charge_Method_Code"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier4_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier4_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier4_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier4_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier4_Ending_Day_Week_Code"),

                                        sInitial_to_Maintenance_Ratio_Member = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Member"),
                                        sInitial_to_Maintenance_Ratio_Hedger = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Hedger"),
                                        sInitial_to_Maintenance_Ratio_Speculator = TierInfo.Field<string>("sInitial_to_Maintenance_Ratio_Speculator")
                                    }
                                  )).ToList();


                mIntraTierInfo = CUtil.LinqQueryToDataTable(qryTierInfo);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("MakefileS Modify " + ex.Message);
            }
        }

        public void MakeInterTierInfo()
        {
            ///Tier Info inter spread
            try
            {
                var qry = (from mrkt in MrktInfo.AsEnumerable()
                           select new
                           {
                               sCombined_Commodity_Code = mrkt.Field<string>("sCombined_Commodity_Code")
                           }).Distinct().ToList();

                DataTable ccd = CUtil.LinqQueryToDataTable(qry);


                ///unique한 정보를 얻는다. 
                var qryTier = (
                                from tier in dt_typeS.AsEnumerable()
                                join mrkt in ccd.AsEnumerable() on new
                                {
                                    sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code")
                                }
                                equals new
                                {
                                    sCombined_Commodity_Code = mrkt.Field<string>("sCombined_Commodity_Code")
                                }
                                select tier
                          );

                DataTable tmp1 = qryTier.CopyToDataTable();


                var qryTierData = ((
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier1_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sScan_Inter_Spread_Method_Code = TierInfo.Field<string>("sScan_Inter_Spread_Method_Code"),
                                        sNumber_of_Tiers = TierInfo.Field<string>("sNumber_of_Tiers"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier1_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier1_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier1_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier1_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier1_Ending_Day_Week_Code"),
                                        sTier_Shot_Option_Minimum_Charge_rate = TierInfo.Field<string>("sTier1_Shot_Option_Minimum_Charge_rate"),
                                        sWeighted_Futures_Price_Risk_Caculation_Method = TierInfo.Field<string>("sWeighted_Futures_Price_Risk_Caculation_Method")
                                    }).Union(
                                     from TierInfo in tmp1.AsEnumerable()
                                     where TierInfo.Field<string>("sTier2_Tier_number").Trim() != ""
                                     select new
                                     {
                                         sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                         sScan_Inter_Spread_Method_Code = TierInfo.Field<string>("sScan_Inter_Spread_Method_Code"),
                                         sNumber_of_Tiers = TierInfo.Field<string>("sNumber_of_Tiers"),
                                         sTier_Tier_number = TierInfo.Field<string>("sTier2_Tier_number"),
                                         sTier_Starting_Month = TierInfo.Field<string>("sTier2_Starting_Month"),
                                         sTier_Ending_Month = TierInfo.Field<string>("sTier2_Ending_Month"),

                                         sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier2_Starting_Day_Week_Code"),
                                         sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier2_Ending_Day_Week_Code"),
                                         sTier_Shot_Option_Minimum_Charge_rate = TierInfo.Field<string>("sTier2_Shot_Option_Minimum_Charge_rate"),
                                         sWeighted_Futures_Price_Risk_Caculation_Method = TierInfo.Field<string>("sWeighted_Futures_Price_Risk_Caculation_Method")
                                     }).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier3_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sScan_Inter_Spread_Method_Code = TierInfo.Field<string>("sScan_Inter_Spread_Method_Code"),
                                        sNumber_of_Tiers = TierInfo.Field<string>("sNumber_of_Tiers"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier3_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier3_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier3_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier3_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier3_Ending_Day_Week_Code"),
                                        sTier_Shot_Option_Minimum_Charge_rate = TierInfo.Field<string>("sTier3_Shot_Option_Minimum_Charge_rate"),
                                        sWeighted_Futures_Price_Risk_Caculation_Method = TierInfo.Field<string>("sWeighted_Futures_Price_Risk_Caculation_Method")
                                    }).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier4_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sScan_Inter_Spread_Method_Code = TierInfo.Field<string>("sScan_Inter_Spread_Method_Code"),
                                        sNumber_of_Tiers = TierInfo.Field<string>("sNumber_of_Tiers"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier4_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier4_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier4_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier4_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier4_Ending_Day_Week_Code"),
                                        sTier_Shot_Option_Minimum_Charge_rate = TierInfo.Field<string>("sTier4_Shot_Option_Minimum_Charge_rate"),
                                        sWeighted_Futures_Price_Risk_Caculation_Method = TierInfo.Field<string>("sWeighted_Futures_Price_Risk_Caculation_Method")
                                    }).Union(
                                    from TierInfo in tmp1.AsEnumerable()
                                    where TierInfo.Field<string>("sTier5_Tier_number").Trim() != ""
                                    select new
                                    {
                                        sCombined_Commodity_Code = TierInfo.Field<string>("sCombined_Commodity_Code"),
                                        sScan_Inter_Spread_Method_Code = TierInfo.Field<string>("sScan_Inter_Spread_Method_Code"),
                                        sNumber_of_Tiers = TierInfo.Field<string>("sNumber_of_Tiers"),
                                        sTier_Tier_number = TierInfo.Field<string>("sTier5_Tier_number"),
                                        sTier_Starting_Month = TierInfo.Field<string>("sTier5_Starting_Month"),
                                        sTier_Ending_Month = TierInfo.Field<string>("sTier5_Ending_Month"),

                                        sTier_Starting_Day_Week_Code = TierInfo.Field<string>("sTier5_Starting_Day_Week_Code"),
                                        sTier_Ending_Day_Week_Code = TierInfo.Field<string>("sTier5_Ending_Day_Week_Code"),
                                        sTier_Shot_Option_Minimum_Charge_rate = TierInfo.Field<string>("sTier5_Shot_Option_Minimum_Charge_rate"),
                                        sWeighted_Futures_Price_Risk_Caculation_Method = TierInfo.Field<string>("sWeighted_Futures_Price_Risk_Caculation_Method")
                                    })).ToList();

                DataTable TmpData = CUtil.LinqQueryToDataTable(qryTierData);



                var qryTierInfo = from data in TmpData.AsEnumerable()
                                  orderby (data.Field<string>("sScan_Inter_Spread_Method_Code"),
                                           data.Field<string>("sCombined_Commodity_Code"),
                                           data.Field<string>("sTier_Tier_number"))
                                  select data;

                mInterTierInfo = qryTierInfo.CopyToDataTable();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("MakefileS Modify " + ex.Message);
            }      
        }

        public void MakefileC_Modify()
        {
            try
            {
                //Combined Commodity Code만 구한다.
                var qry = (
                            from info in MrktInfo.AsEnumerable()
                            select new
                            {

                                sCombined_Commodity_Code = info.Field<string>("sCombined_Commodity_Code")
                            }
                          ).Distinct().ToList();

                DataTable tmp_ccd = CUtil.LinqQueryToDataTable(qry);

                DataTable tmp1 = dt_typeC;
                //tmp1에 필드를 추가하자
                tmp1.Columns.Add("priority", typeof(int));
                tmp1.Columns.Add("priority2", typeof(int));

                DataTable tmp2 = tmp1.Clone();

                int nSeq = 0;


                foreach (DataRow item in tmp1.Rows)
                {
                    item["priority"] = ++nSeq;
                    tmp2.ImportRow(item);

                }

                var qryData = (

                                from typeC in tmp2.AsEnumerable()
                                join ccd in tmp_ccd.AsEnumerable() on new
                                {
                                    sCombined_Commodity_Code = typeC.Field<string>("sCombined_Commodity_Code")
                                }
                                equals new
                                {
                                    sCombined_Commodity_Code = ccd.Field<string>("sCombined_Commodity_Code")

                                }
                                orderby typeC.Field<int>("priority")
                                select typeC
                              );

                DataTable qryTypeC = qryData.CopyToDataTable();

                DataTable tmp3 = qryTypeC.Clone();

                int nSeq2 = 0;

                foreach (DataRow item in qryTypeC.Rows)
                {
                    item["priority2"] = ++nSeq2;
                    tmp3.ImportRow(item);
                }


                //var qryTierToTier = 
                //                      (from tier in tmp3.AsEnumerable()
                //                       where tier.Field<string>("sLeg1_Leg_number") != ""
                //                       select new
                //                       {
                //                           sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                //                           sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                //                           sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                //                           priority2 = tier.Field<int>("priority2"),
                //                           sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                //                           sCharge_Rate = tier.Field<string>("sCharge_Rate"),
                //                           sLeg_Leg_number = tier.Field<string>("sLeg1_Leg_number"),
                //                           sLeg_Tier_number = tier.Field<string>("sLeg1_Tier_number"),
                //                           sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg1_Delta_Per_Spread_Ratio"),
                //                           sLeg_Market_Side = tier.Field<string>("sLeg1_Market_Side")
                //                       }).ToList();

                //DataTable tmp4 = CUtil.LinqQueryToDataTable(qryTierToTier);
                //mFileC = tmp4;
                var qryTierToTier = (
                                          (from tier in tmp3.AsEnumerable()
                                           where tier.Field<string>("sLeg1_Leg_number").Trim() != ""
                                           select new
                                           {
                                               sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                               sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                               sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                               priority2 = tier.Field<int>("priority2"),
                                               sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                               sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate") ).ToString(),
                                               sLeg_Leg_number = tier.Field<string>("sLeg1_Leg_number"),
                                               sLeg_Tier_number = tier.Field<string>("sLeg1_Tier_number"),
                                               sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg1_Delta_Per_Spread_Ratio"),
                                               sLeg_Market_Side = tier.Field<string>("sLeg1_Market_Side")
                                           }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg2_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg2_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg2_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg2_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg2_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg3_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg3_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg3_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg3_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg3_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg4_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg4_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg4_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg4_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg4_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg5_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg5_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg5_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg5_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg5_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg6_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg6_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg6_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg6_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg6_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg7_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg7_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg7_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg7_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg7_Market_Side")
                                          }).Union(
                                          from tier in tmp3.AsEnumerable()
                                          where tier.Field<string>("sLeg8_Leg_number").Trim() != ""
                                          select new
                                          {
                                              sCombined_Commodity_Code = tier.Field<string>("sCombined_Commodity_Code"),
                                              sSpread_Priority = tier.Field<string>("sSpread_Priority"),
                                              sIntracommodity_Spread_Method_Code = tier.Field<string>("sIntracommodity_Spread_Method_Code"),
                                              priority2 = tier.Field<int>("priority2"),
                                              sNumber_of_Legs = tier.Field<string>("sNumber_of_Legs"),
                                              sCharge_Rate = Convert.ToDecimal(tier.Field<string>("sCharge_Rate")).ToString(),
                                              sLeg_Leg_number = tier.Field<string>("sLeg8_Leg_number"),
                                              sLeg_Tier_number = tier.Field<string>("sLeg8_Tier_number"),
                                              sLeg_Delta_Per_Spread_Ratio = tier.Field<string>("sLeg8_Delta_Per_Spread_Ratio"),
                                              sLeg_Market_Side = tier.Field<string>("sLeg8_Market_Side")
                                          })
                                      ).ToList();

                DataTable tmp4 = CUtil.LinqQueryToDataTable(qryTierToTier);

                var qryT = from Data in tmp4.AsEnumerable()
                           orderby Data.Field<int>("priority2")
                           select Data;

                mFileC = qryT.CopyToDataTable();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("MakefileC_Modify" + ex.Message);
            }
        }
    }
           


}
