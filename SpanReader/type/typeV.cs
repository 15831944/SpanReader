using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeV
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    scommodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sFutures_Contract_Month;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sFutures_Contract_Day_Week_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string    sBusiness_Date;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public string    sDaily_Adjustment_Rate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sDaily_adjustment_sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sDaily_adjustment_premium;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public string    sDaily_Adj_Short_Or_Cum_Rate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sDaily_Short_Cumulative_Rate_sign;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sDaily_Short_Cumulative_premium;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sShort_Rate_Flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sLong_position_value_maint_rate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sShort_position_value_maint_rate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sReset_long_margin_price_flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sReset_long_down_threshhold;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sReset_long_up_threshhold;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sReset_short_margin_price_flag;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sReset_short_down_threshhold;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sReset_short_up_threshhold;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sValue_Maintenance_Product_Class;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 44)]
    public string    sFiller;
}