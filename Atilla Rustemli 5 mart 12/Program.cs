namespace Atilla_Rustemli_5_mart_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int n;
         int k;
         int a = 0, b = 1, qaliq;
            int c = 0, d=0;
        l1:
            Console.Write("1-ci 5 reqemli ededi daxil edin: ");
            
           

            if (!(int.TryParse(Console.ReadLine(), out n) && 9999 < n && n < 100000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 5 reqemli ededi daxil edin: ");
           
            
            
            if (!(int.TryParse(Console.ReadLine(), out k) && 9999 < n && n < 100000))
            {
                goto l2;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                a = a + qaliq;
                c++;
                if (c == 1)
                {
                    d = qaliq;
                }
            }
            qaliq = 0;
            while (k > 0)
            {
                qaliq = k % 10;
                k /= 10;
                b = b * qaliq;

            }
            int y = (a + b) * 10 + d;
            Console.WriteLine($"1-ci ededin reqemlerinin cemi ile 2-ci ededin reqemlerinin hasilinin cemi: {a + b}");
            Console.WriteLine($"Alinan ededin sonuna 1-ci ededin son reqeminin artirilmasi: {y}");
        }
    }
}