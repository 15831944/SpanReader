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
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
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

    //Leg1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg1_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg1_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg1_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg1_Market_Side;

    //Leg2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg2_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg2_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg2_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg2_Market_Side;


    //Leg3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg3_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg3_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg3_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg3_Market_Side;


    //Leg4
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg4_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg4_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg4_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg4_Market_Side;


    //Leg5
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg5_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg5_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg5_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg5_Market_Side;



    //Leg6
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg6_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg6_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg6_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg6_Market_Side;



    //Leg7
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg7_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg7_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg7_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg7_Market_Side;



    //Leg8
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg8_Leg_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg8_Tier_number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg8_Delta_Per_Spread_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg8_Market_Side;


    //filler

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 55)]
    public string sFiller;
}