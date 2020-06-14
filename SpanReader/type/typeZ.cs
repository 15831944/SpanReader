using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_typeZ
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sId;


    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sExchange_Acronym;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sCombination_Product_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sCombination_Type;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sCombination_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sCombination_Contract_Day;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sFiller;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg_Number;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg_Relationship;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg_Ratio;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sLeg_Product_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sLeg_Product_Type;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLeg_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg_Contract_Day;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string sLeg_Ratio_Fractional_Part;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg_Price_Available_Flag;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sLeg_Price_Usage_Flag;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sLeg_Price;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sLeg_Price_Sign;




}