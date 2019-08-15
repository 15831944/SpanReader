using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_S_Tier1
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sTier_Tier_number;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sTier_Starting_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sTier_Ending_Month;

}


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_S_Tier2
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sTier_Starting_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sTier_Ending_Day_Week_Code;
}


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_S_Tier3
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sTier_SOM_Charge_Rate;
}



[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeS
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sCombined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sScan_Inter_Spread_Method_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sNumber_of_Tiers;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 70)]
    public _st_S_Tier1[]  st_S_Tier1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sWeig_Fut_Price_Risk_Calc_Method;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public _st_S_Tier2[]  st_S_Tier2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 35)]
    public _st_S_Tier3    st_S_Tier3;
}