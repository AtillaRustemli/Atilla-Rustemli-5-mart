namespace Atilla_Rustemli_5_mart_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("6 reqemli ededi daxil edin: ");
            string eded = Console.ReadLine();
            int n;
            int a = 0, b = 0, c = 0, qaliq;
            if (!(int.TryParse(eded, out n) && 99999 < n && n < 1000000))
            {
                goto l1;
            }
            while (n > 0)
            {
                qaliq = n % 10;
                n /= 10;
                c = c * 10 + qaliq;
                a++;
                


            }
            int x = 0, s = 0, t = 0, q=0;
            while (c > 0)
            {
                s = c % 10;
                c /= 10;
                x = x * 10 + s;
                t++;
                if (t == 1)
                {
                   
                    x -= s;
                    q = s;
                    
                    

                    


                }


            }
            int z = x * 10 ;
            Console.WriteLine ($"Ededin ilk reqeminin ededin sonuna artirilmis formasi: {z+q}");
        }
    }
}