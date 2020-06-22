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

        public static string GetStrikePrice(string fo_tp, string strike_price, string strike_decimal, string strike_alignment)
        {
            double strike_p = 0.0;

            double dDecimal;
            double dAlignment;

            if (fo_tp == "FUT")
            {
                return "";
            }

            if (double.TryParse(strike_price, out strike_p) == false)
            {
                return "";
            }


            if (double.TryParse(strike_decimal, out dDecimal) == false)
            {
                return "";
            }

            if (double.TryParse(strike_alignment, out dAlignment) == false)
            {
                strike_p = strike_p / Math.Pow(10, dDecimal) ;
            }
            else
            {
                strike_p = strike_p / Math.Pow(10, dDecimal) * Math.Pow(10, dAlignment);
            }

               

            return strike_p.ToString();
        }

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
