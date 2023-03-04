namespace Atilla_Rustemli_5_mart_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("6 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 99999 < n && n < 1000000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;

                a++;
                if (a == 6 || a == 5 || a == 4)
                {
                    c += qaliq;
                    


                }
            }
            Console.WriteLine(c);
        }
    }
}