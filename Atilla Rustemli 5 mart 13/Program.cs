namespace Atilla_Rustemli_5_mart_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reqemler-n,k,z
            int n;
            int k;
            int z;
            int a = 0, a1= 0, b = 0,b1=0, qaliq1,qaliq2,qaliq3;
            int c = 0, c1 = 0;
            
        l1:
            Console.Write("1-ci 5 reqemli ededi daxil edin: ");
            


            if (!(int.TryParse(Console.ReadLine(), out n) && 9999 < n && n < 100000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 5 reqemli ededi daxil edin: ");
            if (!(int.TryParse(Console.ReadLine(), out k) && 9999 < k && k < 100000))
            {
                goto l2;
            }
        l3:
            Console.Write("3-cu 5 reqemli ededi daxil edin: ");
           
            if (!(int.TryParse(Console.ReadLine(), out z) && 9999 < z && z < 100000))
            {
                goto l3;
            }
            while (n > 0)
            {
                qaliq1 = n % 10;
                n /= 10;
                a++;
                if (a == 1 || a == 5)
                {
                    a1 = a1 * 10 + qaliq1;
                }
            }
            n = a1;
            a1 = 0;
                qaliq1 = 0;
            while (n > 0)
            {
                qaliq1 = n % 10;
                n /= 10;
                  a1 = a1 * 10 + qaliq1;
                
            }
            while (k > 0)
            {
                qaliq2 = k % 10;
                k /= 10;
                b++;
                if (b == 1 || b == 5){
                    b1 = b1 * 10 + qaliq2;
                }

            }
            k = b1;
            b1 = 0;
            qaliq2 = 0;
            while (k > 0)
            {
                qaliq2 = k % 10;
                k /= 10;
                b1 = b1 * 10 + qaliq2;

            }
            while (z > 0)
            {
                qaliq3 = z % 10;
                z /= 10;
                c++; 
                if(c == 1 || c == 5)
                {
                    c1= c1 * 10 + qaliq3;
                }

            }
            z = c1;
            c1 = 0;
            qaliq3 = 0;
            while (z > 0)
            {
                qaliq3 = z % 10;
                z /= 10;
                c1 = c1 * 10 + qaliq3;

            }
            double d = a1 + b1 + c1;
            double l = d / 2+d;
            Console.WriteLine($"1-ci ededin ilk ve son reqemlerinden alinan eded: {a1}");
            Console.WriteLine($"2-ci ededin ilk ve son reqemlerinden alinan eded: {b1}");
            Console.WriteLine($"3-ci ededin ilk ve son reqemlerinden alinan eded: {c1}");
            Console.WriteLine($"Alinan ededlerin cemi: {d}");
            Console.WriteLine($"Cemin 50 faizi ile ozunun cemi: {l}");

        }
    }
}