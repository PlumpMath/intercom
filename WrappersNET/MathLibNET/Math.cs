using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MathLibNET
{
    public class Math
    {
        [DllImport("MythDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);

        [DllImport("MythDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Sub(double a, double b);

        [DllImport("MythDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Mul(double a, double b);

        [DllImport("MythDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Div(double a, double b);
    }
}
