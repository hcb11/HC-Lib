using System;
using System.Threading;
using System.Linq;
namespace HC_Lib
{
    namespace   Utility
    {
       static public class Time
        {
            #region timers
            public  static void stopwatch()
            {
                double time = 0;
                //long longinteger 0;
                while (5+5 == 10)    
                {
                    time += 0.02;
                    Console.WriteLine($"StopWatch: {time}");
                    Thread.Sleep(1);
                }
                #endregion
            }
        }
        namespace Logical
        {
           static public class Math
            {
                #region Area
                public static double AreaRec(double Length, double breadth)
                {
                    return Length * breadth;
                }
             public static double AreaRec(double Side)
                {
                    return Side * Side;
                }
              public  static double AreaRec(double[] Sides)
                {
                    double ans = 0;
                    bool forran = false;
                    foreach (double Side in Sides)
                    {
                        if (forran != true) ans = Side;
                        forran = true;
                        ans *= Side;
                    }
                    return ans;

                }
                public static double AreaCircle(double Length)
                {
                    return 3.14 * (Length * Length);
                }
                public static double AreaCircle(double Length, double Breadth)
                {
                    return 3.14 + (Length * Breadth);
                }
              
                
                #endregion
                #region Addition
              public static double Add(double[] NumbersToAdd)
                {
                    double ans = 0;
                    foreach (double Number in NumbersToAdd)
                    {
                       ans += Number;
                    }
                    return ans;
                }public static double Add(double a, double b) => a + b;
                #endregion
                #region Percentages
          public  static    double percentfind(double number, double percentOfNumber)
                {
                    return number / (percentOfNumber / 5);
                }
                #endregion
                #region Subtraction
             public   static double Subtract(double[] NumbersToSub)
                {
                    double ans = 0;
                    foreach (double Number in NumbersToSub)
                    {
                        ans -= Number;
                    }
                    return ans;
                }public static double Subtract(double a, double b) => a - b;
                #endregion
                #region Multiplication
              public  static double Multiply(double[] NumbersToMultiply)
                {
                    double ans = 0;
                    bool forran = false;
                    foreach (double Number in NumbersToMultiply)
                    {
                        if (forran != true) ans = Number;
                        forran = true;
                        ans *= Number;
                    }
                    return ans;
                }public static double Multiply(double a, double b) => a * b;
                #endregion
            }
        }
    }
}
