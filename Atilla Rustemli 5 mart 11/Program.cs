using System;

namespace Atilla_Rustemli_5_mart_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0, b = 0, c = 0,d=0,x=0,reqem=0, qaliq;

        l1:
            Console.Write("8 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
           
            if (!(int.TryParse(eded, out n) && 9999999 < n && n < 100000000))
            {
                goto l1;
            }
            while(n > 0){
                qaliq = n % 10;
                n /= 10;

                reqem = reqem * 10 + qaliq;
            }
            n = reqem;
            reqem = 0;
            while (n > 0)
            {
                reqem = n % 10;
                n /= 10;
                x++;
                if (x == 1 || x == 2)
                {
                    a = a * 10 + reqem;
                }
                if (x == 3 || x == 4)
                {
                    b = b * 10 + reqem;
                }
                if (x == 5 || x == 6)
                {
                    c = c * 10 + reqem;
                }
                if (x == 7 || x == 8)
                {
                    d = d * 10 + reqem;
                }
            }
            double y = a + b + c + d;
            double t = y * 100 + 99;
            double r = t - (t * 18) / 100;

            Console.WriteLine($"Iki-iki qruplashmish ededlerin cemi: {y}");
            Console.WriteLine($"Cemin sonuna 99 artirilmasi: {t}");
            Console.WriteLine($"Alinan ededin ozunun 18 faizi ile ferqi: {r}");


        }
    }
}