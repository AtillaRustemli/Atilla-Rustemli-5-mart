namespace Atilla_Rustemli_5_mart_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:





            Console.Write("Ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!int.TryParse(eded, out n))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                
                a++;
                if (a == 1 || a==3)
                {
                    b += qaliq;
                }


            }
            Console.WriteLine($"Verilmis ededin reqemlerinin cemi: {b}");
        }
    }
}