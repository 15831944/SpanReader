using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpanReader.util
{
    public static class CUtil
    {

        /// <summary>
        /// 종목코드를 생성한다.
        /// </summary>
        /// <param name="rArray"></param>
        /// <param name="mrktInfo"></param>
        /// <returns></returns>
        public static string GetSeries(DataRow rArray, DataRow mrktInfo)
        {
            string series = "";
            string tmpStrikeP = "";

            try
            {
                tmpStrikeP = GetStrikePrice(rArray.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sStrike_Price_Sign"), rArray.Field<string>("sOption_Strike_Price"), mrktInfo.Field<string>("sStrike_Price_Decimal"), mrktInfo.Field<string>("sStrike_Price_Alignment"), mrktInfo.Field<string>("sSettlement_Price_Alignment"));

                series = GetSeries(rArray.Field<string>("sProduct_Type_Code"), mrktInfo.Field<string>("MRKT_CD"), rArray.Field<string>("sFutures_Ccyymm"), rArray.Field<string>("sOption_Ccyymm"), rArray.Field<string>("sOption_Right_Code"), tmpStrikeP);

                return series;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        /// <summary>
        /// 종목 코드를 생성한다.
        /// </summary>
        /// <param name="fo_tp"></param>
        /// <param name="mrkt_cd"></param>
        /// <param name="strFut_yyyymmdd"></param>
        /// <param name="strOpt_yyyymmdd"></param>
        /// <param name="strOpt_right"></param>
        /// <param name="strOptStrikeP"></param>
        /// <returns></returns>
        public static string GetSeries(string fo_tp, string mrkt_cd, string strFut_yyyymmdd, string strOpt_yyyymmdd, string strOpt_right, string strOptStrikeP)
        {
            DateTime mrkt_month;
            string strMonth_symbol = "";
            string series = "";


            if (fo_tp == "FUT")
            {
                mrkt_month = DateTime.ParseExact(strFut_yyyymmdd, "yyyyMM", null);
            }
            else
            {
                mrkt_month = DateTime.ParseExact(strOpt_yyyymmdd, "yyyyMM", null);
            }



            string strMonth = mrkt_month.ToString("MM");
            string strYear = mrkt_month.ToString("yy");

            switch (Convert.ToInt32(strMonth))
            {
                case 1:
                    strMonth_symbol = "F";
                    break;
                case 2:
                    strMonth_symbol = "G";
                    break;
                case 3:
                    strMonth_symbol = "H";
                    break;
                case 4:
                    strMonth_symbol = "J";
                    break;
                case 5:
                    strMonth_symbol = "K";
                    break;
                case 6:
                    strMonth_symbol = "M";
                    break;
                case 7:
                    strMonth_symbol = "N";
                    break;
                case 8:
                    strMonth_symbol = "Q";
                    break;
                case 9:
                    strMonth_symbol = "U";
                    break;
                case 10:
                    strMonth_symbol = "V";
                    break;

                case 11:
                    strMonth_symbol = "X";
                    break;
                case 12:
                    strMonth_symbol = "Z";
                    break;

                default:
                    break;
            }


            if (fo_tp == "FUT")
            {
                series = string.Format("{0}{1}{2}", mrkt_cd, strMonth_symbol, strYear);
            }
            else
            {
                series = string.Format("{0}{1}{2}_{3}{4}", mrkt_cd, strMonth_symbol, strYear, strOpt_right, strOptStrikeP);
            }

            return series;



               
        }



        public static string GetSettleP(DataRow rArray, DataRow mrktInfo)
        {
            string settleP = "";
            try
            {
                settleP = GetSettleP(rArray.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sSettlement_Price"), mrktInfo.Field<string>("sSettlement_Price_Decimal"), mrktInfo.Field<string>("sSettlement_Price_Alignment"));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return settleP.ToString();
        }

       
        public static string GetSettleP(string fo_tp, string sSettlement_Price, string sSettlement_Price_Decimal, string sSettlement_Price_Alignment)
        {
            double settleP = 0.0;
            double settle_decimal = 0.0;
            double settle_P_point = 0.0;

            try
            {
                //정산가 raw data가 숫자로 바뀌지 않으면 오류
                if (double.TryParse(sSettlement_Price, out settleP) == false)
                {
                    return "";
                }

                //정산가 소수점 자리수가 raw data가 숫자로 바뀌지 않으면 오류
                if (double.TryParse(sSettlement_Price_Decimal, out settle_decimal) == false)
                {
                    return "";
                }

                if (sSettlement_Price_Alignment.Trim() != "0")
                {
                    settleP = settleP / Math.Pow(10, settle_decimal);

                }



             
                if (sSettlement_Price_Alignment.Trim() == "C" || sSettlement_Price_Alignment.Trim() == "K")
                { int dotPoint = 0;

                    string middle_value = "";
                    dotPoint = settleP.ToString().IndexOf('1');

                    middle_value = settleP.ToString().Substring(dotPoint, 2);
                    settle_P_point = Math.Round(settleP - Math.Floor(settleP), 5);

                    switch (settle_P_point)
                    {
                        case 0.1:
                            settle_P_point = 0.125;
                            break;
                        case 0.2:
                            settle_P_point = 0.25;
                            break;
                        case 0.3:
                            settle_P_point = 0.375;
                            break;
                        case 0.6:
                            settle_P_point = 0.625;
                            break;
                        case 0.7:
                            settle_P_point = 0.75;
                            break;
                        case 0.8:
                            settle_P_point = 0.875;
                            break;
                        default:

                            break;
                    }

                    //strike_p = strike_p + strike_P_point;


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return settleP.ToString();
        }

        /// <summary>
        /// 행사가를 산출한다.
        /// </summary>
        /// <param name="rArray"></param>
        /// <param name="mrktInfo"></param>
        /// <returns></returns>
        public static string GetStrikePrice(DataRow rArray, DataRow mrktInfo)
        {
            string tmpStrike = "";
            try
            {
                if (mrktInfo.Field<string>("MRKT_CD") == "OZT")
                {

                }
                tmpStrike = GetStrikePrice(rArray.Field<string>("sProduct_Type_Code"), rArray.Field<string>("sStrike_Price_Sign"), rArray.Field<string>("sOption_Strike_Price"), mrktInfo.Field<string>("sStrike_Price_Decimal"), mrktInfo.Field<string>("sStrike_Price_Alignment"), mrktInfo.Field<string>("sSettlement_Price_Alignment"));

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return tmpStrike;
        }
        /// <summary>
        /// 행사가를 계산한다.
        /// </summary>
        /// <param name="fo_tp"></param>
        /// <param name="strike_price"></param>
        /// <param name="strike_decimal"></param>
        /// <param name="strike_alignment"></param>
        /// <returns></returns>
        public static string GetStrikePrice(string fo_tp, string strike_sign, string strike_price, string strike_decimal, string strike_alignment, string settlement_alignment)
        {
            double strike_p = 0.0;
            double strike_P_point = 0.0;
            double dDecimal;

            double dStrike_Alignment;
            double dPlus = 1;

            if (strike_sign == "-")
            {
                dPlus = -1;
            }
            //선물일때는 행사가가 필요없다.
            if (fo_tp == "FUT")
            {
                return "";
            }

            try
            {
                //행사가 raw data가 숫자로 바뀌지 않으면 오류
                if (double.TryParse(strike_price, out strike_p) == false)
                {
                    return "";
                }

                //행사가 소수점 정보 raw data가 숫자로 바뀌지 않으면 오류
                if (double.TryParse(strike_decimal, out dDecimal) == false)
                {
                    return "";
                }

                //settlement_alignment 가 C, K 이면 진법표현 형식을 나타냄
                //0 이면 소숫점과 Alignment를 무시함
                //공백이면 행사가 소숫점 정보를 따름 
                if (settlement_alignment.Trim() != "0")
                {
                    //행사가 raw data가 숫자로 바뀌지 않으면 공백또는 오류
                    if (double.TryParse(strike_alignment, out dStrike_Alignment) == false)
                    {
                        strike_p = strike_p / Math.Pow(10, dDecimal);
                    }
                    else
                    {
                        strike_p = strike_p / Math.Pow(10, dDecimal) * Math.Pow(10, dStrike_Alignment);
                    }                    
                }



                if (settlement_alignment.Trim() == "0")
                {

                }
                else if (settlement_alignment.Trim() == "C" || settlement_alignment.Trim() == "K")
                {

                    strike_P_point = Math.Round(strike_p - Math.Floor(strike_p), 5);

                    switch (strike_P_point)
                    {
                        case 0.1:
                            strike_P_point = 0.125;
                            break;
                        case 0.2:
                            strike_P_point = 0.25;
                            break;
                        case 0.3:
                            strike_P_point = 0.375;
                            break;
                        case 0.6:
                            strike_P_point = 0.625;
                            break;
                        case 0.7:
                            strike_P_point = 0.75;
                            break;
                        case 0.8:
                            strike_P_point = 0.875;
                            break;
                        default:
                                
                            break;
                    }

                    strike_p = strike_p + strike_P_point;


                }

                strike_p = strike_p * dPlus;
                return strike_p.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
               

            return strike_p.ToString();
        }

        /// <summary>
        /// Market정보를 구성한다. 
        /// 임시정보
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMrktInfo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("sExchange_Acronym", typeof(string));
            dt.Columns.Add("sCommodity_Code", typeof(string));
            dt.Columns.Add("sContract_Type", typeof(string)); //선물옵션 구분 선물 FUT, 옵션 OOF
            dt.Columns.Add("EXCH_CD", typeof(string));
            dt.Columns.Add("MRKT_CD", typeof(string));


            DataRow Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "AD";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6A";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "EW1";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "1ES";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "EW2";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "2ES";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "EW3";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "3ES";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "EW4";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "4ES";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "BP";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6B";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "C1";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6C";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "EC";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6E";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "J1";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6J";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MP";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6M";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "NE";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6N";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "E1";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "6S";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "CL";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "CL";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "E7";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "E7";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "ES";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "ES";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "GC";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "GC";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "ED";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "GE";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "62";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "GF";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "LN";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "HE";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "HG";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "HG";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "H0";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "H0";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "J7";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "J7";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "48";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "LE";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "M2K";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "M2K";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "M6A";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "M6A";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "M6B";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "M6B";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "M6E";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "M6E";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MCD";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MCD";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MES";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MES";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "MGC";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MGC";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MJY";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MJY";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MNQ";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MNQ";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "MSF";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "MSF";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "NG";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "NG";

            dt.Rows.Add(Dr);



            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "N1";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "NIY";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "NK";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "NKD";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "NQ";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "NQ";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "LO";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "OCL";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "ES";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "OES";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "OG";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "OGC";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "ON";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "ONG";

            dt.Rows.Add(Dr);



            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "NQ";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "ONQ";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "SO";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "OSI";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "PA";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "PA";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "PL";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "PL";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "QG";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "QG";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "QM";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "QM";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "QO";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "QO";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "NYM";
            Dr["sCommodity_Code"] = "RB";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "RB";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "RF";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "RF";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "RP";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "RP";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "RTY";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "RTY";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "RY";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "RY";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CMX";
            Dr["sCommodity_Code"] = "SI";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "SI";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CME";
            Dr["sCommodity_Code"] = "SP";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "CME";
            Dr["MRKT_CD"] = "SP";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "MYM";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "MYM";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "17";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZB";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "C";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZC";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "25";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZF";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "06";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZM";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "21";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZN";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "S";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZS";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "26";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZT";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "2W6";
            Dr["sContract_Type"] = "OOF";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "OZW";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "YM";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "YM";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "17";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZB";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "C";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZC";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "25";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZF";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "07";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZL";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "06";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZM";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "21";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZN";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "0";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZO";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "41";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZQ";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "14";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZR";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "S";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZS";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "26";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZT";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "UBE";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZU";

            dt.Rows.Add(Dr);


            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "W";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZW";

            dt.Rows.Add(Dr);

            Dr = dt.NewRow();
            Dr["sExchange_Acronym"] = "CBT";
            Dr["sCommodity_Code"] = "TN";
            Dr["sContract_Type"] = "FUT";
            Dr["EXCH_CD"] = "ECBOT";
            Dr["MRKT_CD"] = "ZY";

            dt.Rows.Add(Dr);

            return dt;

        }

        public static string ConvertArrayValue(string sign, string value)
        {
            decimal val = 0;


            if (sign.Trim() == "-")
            {
                val = Convert.ToDecimal(value) * -1;
                return val.ToString();
            }
            else
            {
                val = Convert.ToDecimal(value);
                return val.ToString();
            }
        }

        /// <summary>
        /// List 형태를 DataTable로 변환한다.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static DataTable LinqQueryToDataTable(IEnumerable<dynamic> v)
        {
            var firstRecord = v.FirstOrDefault();
            if (firstRecord == null)
            {
                return null;
            }

            PropertyInfo[] infos = firstRecord.GetType().GetProperties();

            DataTable table = new DataTable();

            foreach (var info in infos)
            {
                Type propType = info.PropertyType;

                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
                }
                else
                {
                    table.Columns.Add(info.Name, info.PropertyType);
                }
            }

            DataRow row;

            foreach (var record in v)
            {
                row = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
                }
                table.Rows.Add(row);
            }

            table.AcceptChanges();

            return table;
        }
    }
}
