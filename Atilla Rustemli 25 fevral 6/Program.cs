namespace Atilla_Rustemli_25_fevral_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("8 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 9999999 < n && n < 100000000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c * 10 + qaliq;
                a++;
                if (a == 1 || a == 8)
                {
                    c -= qaliq;
                    c /= 10;


                }
                

            }
            int x = 0, s = 0;
            while (c > 0)
            {
                s = c % 10;
                c /= 10;
                x = x * 10 + s;
                a++;
                
                
            }
            Console.WriteLine($"Ededin ilk ve son ededini cixartdiqda: {x}");
        }
    }
}