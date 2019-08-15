using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeP
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sCommodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sProduct_Type_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string    sProduct_Name;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sSettlement_Price_Decimal;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sStrike_Price_Decimal;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sSettlement_Price_Alignment;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sStrike_Price_Alignment;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string    sContract_Value_Factor;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string    sStandard_Cabinet_Opt_Value;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sQuoted_Position_Quantity;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sSettle_Currency_ISO_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sSettle_Currency_One_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sPrice_Quotation_Method;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sContract_Value_Factor_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sContract_Value_Factor_Expo;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string    sExercise_Style;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 35)]
    public string    sProduct_Long_Name;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sPosition_Product_Indicator;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sMoney_Calc_Method;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sValuation_Method;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sSettlement_Method;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sFX_Forward_Products;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sFX_Pre_Spot_Date;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sFX_Pre_Spot_Date_Week_Num;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string    sFX_Forward_Credit_Rate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string    sEquiv_Pos_Fact;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sEquiv_Pos_Fact_Exp;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sEquiv_Pos_Fact_Exp_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sVariable_Tick_Option_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sPrice_Quot_Currency;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sOption_Money_Condition;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sOption_Contrary_Instruction;
}
