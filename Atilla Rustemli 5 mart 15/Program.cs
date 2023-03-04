using System.Globalization;

namespace Atilla_Rustemli_5_mart_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            int qaliq,qaliq5;
            int n = 0;
            long k;
            int n1 = 0, n5 = 0, n6 =0 ;

        l1:
            Console.Write("1-ci 3 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out a) && 99 < a && a < 1000))
            {
                goto l1;
            }
        l2:
            Console.Write("1-ci 3 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out b)&& 99 < b && b < 1000))
            {
                goto l2;
            }
        l3:
            Console.Write("1-ci 6 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out c) && 99999 < c && c < 1000000))
            {
                goto l3;
            }

        l4:
            Console.Write("2-cu 6 reqemli ededi daxil edin: ");



            if (!(int.TryParse(Console.ReadLine(), out d) && 99999 < d && d < 1000000))
            {
                goto l4;
            }
        l5:
            Console.Write("7 reqemli ededi daxil edin: ");

            if (!(int.TryParse(Console.ReadLine(), out e) && 999999 < e && e < 10000000))
            {
                goto l5;
            }
            int p = e;
            int again = e;

            int x = a + b;
            
            while (x > 0)
            {
                qaliq = x % 10;
                x /= 10;
                n++;
                if (n == 1 || n == 2)
                {
                    n1 = n1 * 10 + qaliq;
                }


            }
            x = n1;
            n1 = 0;
            
                qaliq = 0;
            while (x > 0)
            {
                qaliq = x % 10;
                x /= 10;
                n1 = n1 * 10 + qaliq;
            }
            n1 *= n1;
            int bit = a * 1000 + b + n1;
            int son5 = e % 100000;
            int z = bit - son5;
            long q = z + (c + d) % 1000;
            while(p>0)
            {
                qaliq5 = p % 10;
                p /= 10;
                n5+= qaliq5;

            }
            p = n5;
            n5 = 0;
            qaliq5 = 0;
            while (p > 0)
            {
                qaliq5 = p % 10;
                p /= 10;
                n5 =n*10 + qaliq5;
            }
            long t = q + n5;
            t = t * 100 + 11;

            bool tr = true;
            int w, i = 0;
            while(again>0)
            {
                w = again % 10;
                again/= 10;
                if (tr == false)
                {
                    tr = !tr;
                    continue;
                }
                tr = !tr;
                i = i * 10 + w;
            }
            again = i;
            i = 0;
            w = 0;
            while (again > 0)
            {
                w = again % 10;
                again /= 10;
                i=i*10+ w;
            }
            
            long j = t - i;
            long s = j;
            long h=0;
            while (j > 0)
            {
                k = j % 10;
                j /= 10;
                 h = h * 10 + k;
                n6++;
                if (n6 == 1)
                {
                    
                    h = h * 100 + 88;
                }
                

            }
            j = h;
            h = 0;
            k = 0;
            while (j > 0)
            {
                k = j % 10;
                j /= 10;
                
                h = h * 10 + k;

            }
            Console.WriteLine($" 3 reqemli ededlerin ceminin son 2 reqeminin kvadrati ile onlarin bitshik formasinin cemi: {bit}");
            Console.WriteLine(" ");
            Console.WriteLine($"Alinan cavabin 7 reqemli ededin son 5 reqemi ile ferqi: {z}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ferqin 6 reqemli ededlerin cemi ile son 3 reqeminin yaratdigi ededin cemi: {q}");
            Console.WriteLine(" ");
            Console.WriteLine($"Cemin 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan ededle ceminin sonuna 11 artirilmish formasi: {t} ");
            Console.WriteLine(" ");
            Console.WriteLine($"Alinan ededin 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededle ferqi: {s}");
            Console.WriteLine(" ");
            Console.WriteLine($" Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave edilmish formasi: {h}");
            Console.WriteLine(" ");



        }
    }
}