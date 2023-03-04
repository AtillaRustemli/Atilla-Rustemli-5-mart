namespace Atilla_Rustemli_5_mart__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("9 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 99999999 < n && n < 1000000000))
            {
                goto l1;
            }
            int y = n;
            bool k = true;
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c * 10 + qaliq;


            }
;
            int t = 0;
            while (c > 0)
            {

                b = c % 10;
                c /= 10;
                if (k == false)
                {
                    k = !k;
                    continue;
                }
                k = !k;
                t = t * 10 + b;
            }
            bool q=true;
            int r = 0;
            int z = 0;
            while (y > 0)
            {

               r = y % 10;
                y /= 10;
               
             z = z * 10 + r;
            }
            y = z;
            z = 0;
            int l = 0;
            while (y > 0)
            {

                l = y % 10;
                y /= 10;
                if (q == true)
                {
                    q = !q;
                    continue;
                }
                q = !q;
                z = z * 10 + l;
            }
            
            Console.WriteLine($"Tek ve cut yerde duran ededlerin cemi: {t + z}");

        }
    }
}
