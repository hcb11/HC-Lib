using System;
using System.Threading;
using System.Linq;
namespace HC_Lib
{
    namespace   Utility
    {
       static public class Time
        {
          public  static void stopwatch()
            {
                double time = 0;
                //long longinteger 0;
                while (5+5 == 10)    
                {
                    time += 0.0001;
                    Console.WriteLine(time);
                    Thread.Sleep(0001);
                }
            }
        }
        namespace Logical
        {
           static public class Math
            {
                #region Area
               static double AreaRec(double Length, double breadth)
                {
                    return Length * breadth;
                }
             static double AreaRec(double Side)
                {
                    return Side * Side;
                }
                static double AreaRec(double[] Sides)
                {
                    double ans = 0;
                    bool forran = false;
                    foreach (double Side in Sides)
                    {
                        if (forran != true) ans = Side;
                        ans *= Side;
                    }
                    return ans;

                }
               static double AreaCircle(double Length, double Breadth)
                {
                    return 3.14 + (Length * Breadth);
                }
              static  double AreaCircle(double Length)
                {
                    return 3.14 * (Length * Length);
                }
                
                #endregion
                #region Addition
               static double Add(double[] NumbersToAdd)
                {
                    double ans = 0;
                    foreach (double Number in NumbersToAdd)
                    {
                       ans += Number;
                    }
                    return ans;
                }
                #endregion
                #region Percentages
            static    double percentfind(double number, double percentOfNumber)
                {
                    return number / (percentOfNumber / 5);
                }
                #endregion
            }
        }
    }
}
