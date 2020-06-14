using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode, Pack=1)]
public struct _st_type2_arr
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sCommodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller;
}

[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode, Pack=1)]
public struct _st_type2
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sFiller1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sRisk_Exponent;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sPerform_Currency_ISO_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sPerform_Currency_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sOption_Margin_Style;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sLimit_Option_Value_Net_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCombination_Margining_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sFiller2;

    //arr1
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller_a1;

    //arr2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller_a2;

    //arr3
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a3;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a3;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a3;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a3;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller_a3;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a4;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller_a4;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a5;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a5;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a5;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a5;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller_a5;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCommodity_Code_a6;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sContract_Type_a6;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Locator_a6;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sRisk_Array_Decimal_Sign_a6;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string sFiller_a6;


}