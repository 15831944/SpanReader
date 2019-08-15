using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_type2_arr1
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    char    sCommodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    char    sContract_Type;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    char    sRisk_Array_Decimal_Locator;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    char    sRisk_Array_Decimal_Sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    char    sFiller;
}

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
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
    
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
    public _st_type2_arr1[]    st_type2_arr1;
    

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string    sFiller3;


}