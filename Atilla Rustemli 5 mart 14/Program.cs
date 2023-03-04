namespace Atilla_Rustemli_5_mart_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int z;
            int t;
            int a = 0, a1 = 0, b = 0, b1 = 0, qaliq1, qaliq2, qaliq3, qaliq4;
            int c = 0, c1 = 0, d = 0, d1 = 0;
            int t1, t2, t3, t4;

        l1:
            Console.Write("1-ci 6 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out n) && 99999 < n && n < 1000000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 6 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out k) && 99999 < k && k < 1000000))
            {
                goto l2;
            }

        l3:
            Console.Write("3-cu 6 reqemli ededi daxil edin: ");



            if (!(int.TryParse(Console.ReadLine(), out z) && 99999 < z && z < 1000000))
            {
                goto l3;
            }
        l4:
            Console.Write("7 reqemli ededi daxil edin: ");

            if (!(int.TryParse(Console.ReadLine(), out t) && 999999 < t && t < 10000000))
            {
                goto l4;
            }
            int al=t;

            while (n > 0)
            {
                qaliq1 = n % 10;
                n /= 10;
                a++;
                if (a == 4 || a == 5 || a == 6)
                {
                    a1 = a1 * 10 + qaliq1;
                }
            }
            n = a1;
            a1 = 0;
            
            while (n > 0)
            {
                t1 = n % 10;
                n /= 10;
                a1 = a1 * 10 + t1;

            }
            while (k > 0)
            {
                qaliq2 = k % 10;
                k /= 10;
                b++;
                if (b == 4 || b == 5 || b == 6)
                {
                    b1 = b1 * 10 + qaliq2;
                }

            }
            k = b1;
            b1 = 0;
            
            while (k > 0)
            {
                t2 = k % 10;
                k /= 10;
                b1 = b1 * 10 + t2;

            }
            while (z > 0)
            {
                qaliq2 = z % 10;
                z /= 10;
                c++;
                if (c == 4 || c == 5 || c == 6)
                {
                    c1 = c1 * 10 + qaliq2;
                }

            }
            z = c1;
            c1 = 0;

            while (z > 0)
            {
                t3 = z % 10;
                z /= 10;
                c1 = c1 * 10 + t3;

            }

            while (t > 0)
            {
                qaliq4 = t % 10;
                t /= 10;
                d++;
                if (d == 1 || d == 2 || d == 3 || d == 4)
                {
                    d1 = d1 * 10 + qaliq4;
                }

            }
            t = d1;
            d1 = 0;
            d = 0;
            
            while (t > 0)
            {
                t4 = t % 10;
                t /= 10;
                d1 = d1 * 10 + t4;

            }
            double x = a1 + b1 + c1 + d1;
            
            d1 = 1;
            int l = 0;
            while (al > 0)
            {
                l = al % 10;
                al /= 10;
                d++;
                if (d == 5 || d == 6||d==7)
                    d1 *= l;

            }

            double g = x - d1;
            double faiz60 = (g * 6) / 10;
            double add60 = faiz60 * 100 + 60;
            double cix18f = add60 - (add60 * 18) / 100;
            Console.WriteLine($"6 reqemli ededlerin ilk 3 rememlerinden alinan ededle 7 reqemli ededin son 4 reqeminden alinan ededin cemi: {x}");
            Console.WriteLine($"Cemin 7 reqemli ededin ilk 3 reqeminin hasili ile ferqi: {g}");
            Console.WriteLine($"Ferqin 60 faizi: {faiz60}");
            Console.WriteLine($"Ferqin 60 faizinin sonuna 60 ededi elave etdikde: {add60}");
            Console.WriteLine($"Alinan ededinn ozu ile 18 faizinin ferqi: {cix18f}");
            
        }
    }
}