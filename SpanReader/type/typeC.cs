using System;
using System.Runtime.InteropServices;



[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_Leg
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sLeg_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sLeg_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sLeg_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sLeg_Market_Side;
}


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeC
{
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sIntracommodity_Spread_Method_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sSpread_Priority;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sNumber_of_Legs;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sCharge_Rate;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public  _st_Leg[]   st_legs;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 55)]
    public string sFiller;
}