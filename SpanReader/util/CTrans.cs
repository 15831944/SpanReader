using System;
using System.IO;
//using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;


public class CTrans<T> where T: struct
{
    private T m_tr;
    public CTrans()
    {
       // m_tr = TR;        
    }

    public T ByteToStruct(string streamData)
    {

        //입력받은 string을 Byte 배열로 변환 
        

        int type_size = Marshal.SizeOf(typeof(T));
        byte[] byteData = Encoding.Unicode.GetBytes(streamData.ToString().PadRight(type_size));

        
        

            if (type_size > byteData.Length)
            {
                return m_tr;
            }

            IntPtr buffer = Marshal.AllocHGlobal(type_size);
            Marshal.Copy(byteData, 0, buffer, type_size);

            T obj = (T)Marshal.PtrToStructure(buffer, typeof(T));
            Marshal.FreeHGlobal(buffer);

            return obj;
    }


    
}