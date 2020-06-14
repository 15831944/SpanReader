using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_type3
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sIntracommodity_Spread_Charge_Method_Code;
   

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

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sFiller1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sInitial_to_Maintenance_Ratio_Member;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sInitial_to_Maintenance_Ratio_Hedger;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sInitial_to_Maintenance_Ratio_Speculator;

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

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public string sFiller2;


}