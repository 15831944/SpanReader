using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_typeS
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sScan_Inter_Spread_Method_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sNumber_of_Tiers;

    //tier1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier1_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier1_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier1_Ending_Month;

    //tier2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier2_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier2_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier2_Ending_Month;


    //tier3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier3_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier3_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier3_Ending_Month;

    //tier4
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier4_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier4_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier4_Ending_Month;

    //tier5
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier5_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier5_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTier5_Ending_Month;



    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sWeighted_Futures_Price_Risk_Caculation_Method;

    //Tier 1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier1_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier1_Ending_Day_Week_Code;

    //Tier 2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier2_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier2_Ending_Day_Week_Code;

    //Tier 3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier3_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier3_Ending_Day_Week_Code;


    //Tier 4
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier4_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier4_Ending_Day_Week_Code;


    //Tier 5
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier5_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sTier5_Ending_Day_Week_Code;


    //Shot Option Minimum
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTier1_Shot_Option_Minimum_Charge_rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTier2_Shot_Option_Minimum_Charge_rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTier3_Shot_Option_Minimum_Charge_rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTier4_Shot_Option_Minimum_Charge_rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTier5_Shot_Option_Minimum_Charge_rate;


}