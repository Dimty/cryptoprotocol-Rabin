using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace cryptoprotocol_Rabin
{

    class Program
    {
        private static void OldVersion()
        {
            //public static int UnNOD(int a, int b, out int x, out int y)
            //{
            //    if (b < a)
            //    {
            //        a ^= b;
            //        b ^= a;
            //        a ^= b;
            //    }
            //    if (a == 0)
            //    {
            //        x = 0;
            //        y = 1;
            //        return b;
            //    }
            //    int gcd = UnNOD(b % a, a, out x, out y);//рекурсивно получаем НОД и с каждым 
            //    int y1 = x;                             //последующим выходом из функции высчитываем 
            //    x = y - (b / a) * x;                    //коэффициенты для "a" и "b"
            //    y = y1;
            //    return gcd;

            //}
            //static void Main(string[] args)
            //{

            //    Console.Write("P=");
            //    _ = int.TryParse(Console.ReadLine(), out int p);
            //    Console.Write("Q=");
            //    _ = int.TryParse(Console.ReadLine(), out int q);
            //    int n = p * q;
            //    Console.Write("B=");
            //    _ = int.TryParse(Console.ReadLine(), out int b);
            //    Console.Write("M=");
            //    _ = int.TryParse(Console.ReadLine(), out int M);
            //    int C = (M * (M + b)) % n;
            //    Console.WriteLine($"C={C}");

            //    int D = ((int)Math.Pow(b, 2) + 4 * C) % n;
            //    Console.WriteLine($"D={D}");

            //    int s, r;
            //    s = (int)(Math.Pow(D, (p + 1) / 4) % p);
            //    r = (int)(Math.Pow(D, (q + 1) / 4) % q);
            //    Console.WriteLine($"s={s},r={r}");


            //    int yp, yq;
            //    UnNOD(p, q, out yp, out yq);
            //    Console.WriteLine($"Yp={yp},Yq={yq}");
            //    if (p > q)
            //    {
            //        yp ^= yq;
            //        yq ^= yp;
            //        yp ^= yq;
            //    }

            //    Console.WriteLine($"Yp={yp},Yq={yq}");

            //    int d1, d2, d3, d4;
            //    d1 = (yp * p * r + yq * q * s) % n;
            //    Console.WriteLine($"({yp}*{p}*{r}+{yq}*{q}*{s})%{n}");
            //    d2 = n - d1;

            //    d3 = (yp * p * r - yq * q * s) % n;
            //    d4 = n - d3;

            //    Console.WriteLine($"d1={d1},d2={d2},d3={d3},d4={d4}");
            //    int m1, m2, m3, m4;
            //    if ((-b + d1) > 0)
            //    {
            //        Math.DivRem((-b + d1) / 2, n, out m1);
            //    }
            //    else
            //    {
            //        m1 = n - (b - d1) / 2;
            //    }
            //    if ((-b + d2) > 0)
            //    {
            //        Math.DivRem((-b + d2) / 2, n, out m2);
            //    }
            //    else
            //    {
            //        m2 = n - (b - d2) / 2;
            //    }
            //    if ((-b + d3) > 0)
            //    {
            //        Math.DivRem((-b + d3) / 2, n, out m3);
            //    }
            //    else
            //    {
            //        m3 = n - (b - d3) / 2;
            //    }
            //    if ((-b + d4) > 0)
            //    {
            //        Math.DivRem((-b + d4) / 2, n, out m4);
            //    }
            //    else
            //    {
            //        m4 = n - (b - d4) / 2;
            //    }
            //    //Math.DivRem((-b + d2) / 2, n, out int m2);
            //    //Math.DivRem((-b + d3) / 2, n, out int m3);
            //    //Math.DivRem((-b + d4) / 2, n, out int m4);
            //    // m2 = ((-b + d2) / 2) % n;

            //    Console.WriteLine($"m1 ={ m1},m2 ={ m2},m3 ={ m3},m4 ={ m4}");

            //    Console.ReadKey();



            //}
        }
        private static void OpdVersion2()
        {
            //public static int KTO(int mod1, int mod2, int v1, int v2)
            //{0011010101010111010110111101101110101001
            //    int M0 = mod1 * mod2;
            //    int N1 = (int)BigInteger.ModPow(mod2, mod1 - 2, mod1);
            //    int N2 = (int)BigInteger.ModPow(mod1, mod2 - 2, mod2);
            //    return (mod2 * N1 * v1 + mod1 * N2 * v2) % M0;
            //}

            //static void Main()
            //{
            //    int p, q, n;
            //    Console.Write($"p=");
            //    int.TryParse(Console.ReadLine(), out p);
            //    Console.Write($"q=");
            //    int.TryParse(Console.ReadLine(), out q);
            //    n = q * p;

            //    Console.Write($"m=");
            //    int.TryParse(Console.ReadLine(), out int m);

            //    int c = (int)((Math.Pow(m, 2)) % n);

            //    int[] ai = new int[4];
            //    ai[0] = (int)((Math.Pow(c, (p + 1) / 4)) % p);
            //    ai[1] = p - ai[0];

            //    ai[2] = (int)(Math.Pow(c, (q + 1) / 4)) % q;
            //    ai[3] = q - ai[2];

            //    int[] mi = new int[4];
            //    byte t = 0;
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 2; j < 4; j++)
            //        {
            //            mi[t] = KTO(p, q, ai[i], ai[j]);
            //            t++;
            //        }
            //    }






            //    Console.ReadKey();

            //}
        }
        public static int UnNOD(int a, int b, out int x, out int y)
        {
            if (b < a)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int gcd = UnNOD(b % a, a, out x, out y);//рекурсивно получаем НОД и с каждым 
            int y1 = x;                             //последующим выходом из функции высчитываем 
            x = y - (b / a) * x;                    //коэффициенты для "a" и "b"
            y = y1;
            return gcd;
        }
        public static int Modulus(int a, int b)
        {
            bool negative=false;
            if (a < 0)
            {
                negative = true;
                a=Math.Abs(a);
            }
            while (a > b)
            {
                a -= b;
            }
            if (negative) return b - a;
            else return a;
        }

        static void Main()
        {
            int p, q, n;
            Console.Write($"p=");
            int.TryParse(Console.ReadLine(), out p);
            Console.Write($"q=");
            int.TryParse(Console.ReadLine(), out q);
            n = q * p;

            Console.Write($"m=");
            int.TryParse(Console.ReadLine(), out int m);

            int c = (int)BigInteger.ModPow(m, 2, n);

            int digree = (p + 1) / 4;
            int mp = (int)BigInteger.ModPow(c, digree, p);
            digree = (q + 1) / 4;
            int mq=(int)BigInteger.ModPow(c, digree, q);

            UnNOD(p, q, out int yp, out int yq);
            if(p>q)
            {
                yp ^= yq;
                yq ^= yp;
                yp ^= yq;
            }


            int r1, r2, r3, r4;
            r1 = (yp * p * mq + yq * q * mp) % n;
            r1 = Modulus(yp * p * mq + yq * q * mp, n);

            r2 = n - r1;
            r3 = (yp * p * mq - yq * q * mp) % n;
            r3 = Modulus(yp * p * mq - yq * q * mp, n);
            r4 = n - r3;

            Console.WriteLine($"r1={r1},r2={r2},r3={r3},r4={r4},");
            Console.ReadLine();


        }

    }
}
