using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_type6
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sCommodity_Group_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string    sSpread_Priority;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sSpread_Credit_Rate_Percent;


    //tier1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg1_Exchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg1_Required_Scanning_Based_Spread_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg1_Combined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg1_Spread_Ratio;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg1_Spread_Side;


    //tier2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg2_Exchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg2_Required_Scanning_Based_Spread_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg2_Combined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg2_Spread_Ratio;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg2_Spread_Side;


    //tier3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg3_Exchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg3_Required_Scanning_Based_Spread_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg3_Combined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg3_Spread_Ratio;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg3_Spread_Side;

    //tier4
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg4_Exchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg4_Required_Scanning_Based_Spread_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg4_Combined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg4_Spread_Ratio;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg4_Spread_Side;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sIntercommodity_Spread_Method_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sTarget_Exchange_Acronym;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sTarget_Leg_Required_Flag;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sTarget_Combined_Commodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sCredit_Calculation_Method;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg1_Tier_Number;


    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg2_Tier_Number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg3_Tier_Number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg4_Tier_Number;


    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSpread_Group_Flag;


    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTarget_Lg_Delta_per_Spread_Ratio;


    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sMinimum_Number_of_Legs_Required;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSpread_Credit_Rate_Defined_Separately_for_each_Leg;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg1_Spread_Credit_Rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg2_Spread_Credit_Rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg3_Spread_Credit_Rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg4_Spread_Credit_Rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRegulatory_Status_Eligibility_Code;


}