using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, Pack=1)]
public struct _st_typeX
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string    sID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string    sCombination_Margining_Method_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string    sProduct_Commodity_Code;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string    sPrice_Offset;
}