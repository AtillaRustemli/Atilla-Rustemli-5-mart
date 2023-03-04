namespace Atilla_Rustemli_5_mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("8 reqemli ededi daxil edin: ");
            string eded=Console.ReadLine();
            int n;
            int a = 0, b = 0, qaliq;
            if(!(int.TryParse(eded, out n)&&9999999<n&&n<100000000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                a++;
                if (a == 4 || a == 5 || a == 6)
                {
                    b += qaliq;


                }   
            }
            Console.WriteLine($"Ededin ortasinda yerleshen 3 reqemin cemi: {b}");
            
            

        }
    }
}