using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
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

    //Leg1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sLeg1_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg1_Rem_Part_of_Contract_Period;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg1_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg1_Market_Side;

    //Leg2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sLeg2_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg2_Rem_Part_of_Contract_Period;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg2_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg2_Market_Side;

    //Leg3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sLeg3_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg3_Rem_Part_of_Contract_Period;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg3_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg3_Market_Side;

    //Leg4
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sLeg4_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg4_Rem_Part_of_Contract_Period;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg4_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg4_Market_Side;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sFiller;
}

