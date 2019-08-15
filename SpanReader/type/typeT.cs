using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeT
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sConvert_To_Currency_ISO_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sConvert_To_Currency_Byte_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string    sConvert_From_Currency_ISO_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sConvert_From_Currency_Byte_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sConversion_Multiplier;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sConversion_Multiplier_Decimal_Locator;
}