using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class Class1
    {
        
            public static double sum(double a, double b)
            {
                return a + b;
            }

            public static double diff(double a, double b)
            {
                return a - b;
            }

            public static double mult(double a, double b)
            {
                return a * b;
            }

            public static double div(double a, double b)

            {
                if (b == 0) 
                {
                    return 000000;
                } 
                return a / b;
            }

            public static double mod(double a, double b)
            {
                return a % b;
            }

            public static double pow(double a, double n)
            
            {
                double res = 1;
                while (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        a *= a;
                    }
                    else
                    {
                        n--;
                        res *= a;
                    }
                }
                return res;
            }

           public static double abs(double a)
           {
                if (a > 0)
                {
                    return a;
                }
                else
                    return -a;
           }

           public static double sqrt(double  a)
           {
                double step = 0.01;
                double begin = 0.0;
                double end = a;
                double middle = (end + begin) / 2.0;
                while(abs(pow(middle,2) - a) >= step)
                {
                    if (pow(middle, 2) < a)
                    {
                        begin = middle;
                    }
                    else
                    {
                        end = middle;
                    }
                    middle = (end + begin) / 2.0;
                }
                return middle;
           }

           public static double pi()
           {
               return 3.1415926;
           }
    }
}
