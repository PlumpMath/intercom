using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace StringLibNET
{
    public class StringLib
    {
        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int getStringLength(String s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern int getWhiteSpaceCount(String s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void removeSpaces(String s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void trim(StringBuilder s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void trimLeft(String s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void trimRight(String s);

        [DllImport("StringLib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string getVersionInfo();
    }
}
