namespace Atilla_Rustemli_5_mart_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("5 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 9999 < n && n < 100000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c * 10 + qaliq;
                a++;
                if (a == 1 || a == 5)
                {
                    b += qaliq;



                }
               
            }
            Console.WriteLine($"Verilmis ededin 1 ve 5 ci reqeminin cemi: {b*b}");

        }
    }
}