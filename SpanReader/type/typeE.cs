using System;
using System.Runtime.InteropServices;



[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_E_Leg
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string    sLeg_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sLeg_Rem_Part_of_Contract_Period;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sLeg_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sLeg_Market_Side;
}


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeE
{
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sSpread_Priority;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sCharge_Rate;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public  _st_E_Leg[]   st_legs;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sFiller;
}

