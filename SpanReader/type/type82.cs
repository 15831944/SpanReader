using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_type82
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sCommodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sUnderlying_Commodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sProduct_Type_Code7;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sOption_Right_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sFutures_Ccyymm;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sFuture_Day_Week_Code4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sFiller_1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sOption_Ccyymm;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sOption_Day_Week_Code4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sFiller_2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sOption_Strike_Price;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_10_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_10_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_11_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_11_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_12_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_12_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_13_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_13_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_14_Value;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_14_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_15_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_15_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sArray_16_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sArray_16_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sSpan_Composite_Delta;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sSpan_Composite_Delta_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string    sImplied_Volatility;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sSettlement_Price;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sSettlement_Price_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sStrike_Price_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sCurrent_Delta;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCurrent_Delta_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCurrent_Delta_Bsns_Day_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sStart_Of_Day_Price;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sStart_Of_Day_Price_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sImplied_Volatility_Exponent;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sImplied_Volatility_Exponent_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string    sCont_Cont_Val_Fact;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sCont_Cont_Val_Fact_Exp;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCont_Cont_Val_Fact_Exp_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string    sCont_Strike_Val_Fact;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sCont_Strike_Val_Fact_Exp;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCont_Strike_Val_Fact_Exp_Sign;    
}