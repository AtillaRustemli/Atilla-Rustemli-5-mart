namespace Atilla_Rustemli_5_mart_9
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
            bool k = true;
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c*10 + qaliq;


            }
            
            n = c;
            c = 0;
            while (n > 0)
            {
                
                b = n % 10;
                n /= 10;
             if (k == false)
                {
                    k = !k;
                    continue;
                }
                k = !k;
                c = c * 10 + b;
            }
            Console.WriteLine($"Verilmis ededin reqemlerinin cemi: {c}");
        }
    }
}