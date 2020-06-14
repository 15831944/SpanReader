using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_typeR
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sExchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sProduct_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sCombined_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sAlternate_Exchange_Acronym;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sAlternate_Product_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string    sAlternate_Combined_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 90)]
    public string    sFiller;

}
