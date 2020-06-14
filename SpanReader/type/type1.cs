using System;
using System.Runtime.InteropServices;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_type1
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sId;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string sExchange_Acronym;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sFiller1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string sExchange_Code;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 123)]
    public string sFiller2;            

}
