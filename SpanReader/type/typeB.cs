using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_typeB
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sCommodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sProduct_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sFutures_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sFutures_Contract_Day;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sOption_Contract_Month;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sOption_Contract_Day;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string sBase_Volatility;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string sVolatility_Scan_Range;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sFutures_Price_Scan_Range;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sExtreme_Move_Multiplier;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sExtreme_Move_Covered_Fraction;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sInterest_Rate;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sTimeToExpiration;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sLookahead_Time;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string sDelta_Scaling_Factor;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string sExpiration_Date;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sUnderlying_Commodity_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sPricing_Model;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string sCoupon_Dividend_Yield_decimal_fraction;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sOption_Expiration_Reference_Price_Flag;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string sOption_Expiration_Reference_Price;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sOption_Expiration_Reference_Price_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string sSwap_Value_Factor;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sSwap_Value_Factor_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSign_for_Swap_Value_Factor_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sBase_Volatility_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSign_Base_Volatility_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sVolatility_Scan_Range_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSign_for_Volatilit_Scan_Range_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
    public string sDiscount_Factor;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sVolatility_Scan_Range_Quotaion_method;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sPrice_Scan_Range_Quotation_Method;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sFutures_Price_Scan_Range_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sSign_for_Futures_Price_San_Range_Exponent;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string sDelivery_Margin_Method;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string sMargin_Removal_Date;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sMargin_Removal_Cycle;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sInterest_Rate_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string Coupon_or_Dividend_Yield_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
    public string sHigh_Precision_Option_Expiration_Reference_Price;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sHigh_Precision_Option_Expiration_Reference_Price_Sign;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sHigh_Precision_Option_Expiration_Reference_Price_Flag;

}