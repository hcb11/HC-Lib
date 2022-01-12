using System;
using HC_Lib;
using HC_Lib.Utility;
using HC_Lib.Utility.Logical;
using Math = HC_Lib.Utility.Logical.Math;

namespace program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Time.stopwatch();
           /*2 number ADDITION TEST*/ Console.WriteLine(Math.Add(2, 2));
           /*Array ADDITION TEST*/ Console.WriteLine(Math.Add(i));
           /*Array Multiplication Test*/ Console.WriteLine(Math.Multiply(i));
           /* 2 number multiplication test*/ Console.WriteLine(Math.Multiply(2, 5));
            /* Circle Area test*/ Console.WriteLine(Math.AreaCircle(5));
            /*Square Area Test*/ Console.WriteLine(Math.AreaRec(5));
            
        }
    }
}