namespace Atilla_Rustemli_5_mart_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("4 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 999 < n && n < 10000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c  + qaliq;
                
                
            }
            Console.WriteLine($"Verilmis ededin reqemlerinin cemi: {c}");

        }
    }
}