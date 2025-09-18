using System;

class Program
{
    static void F15()
    {
        Console.Write("K�rek egy pozit�v eg�sz sz�mot: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            if (i < n) Console.Write(" ");
        }
        Console.WriteLine();
    }
    static void F16()
    {
        Console.Write("K�rek egy pozit�v eg�sz sz�mot: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
    static void F17()
    {
        Console.Write("K�rek egy pozit�v eg�sz sz�mot: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Oszt�k: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        // 15.feladat
        

        // 16. feladat

        // 17. feladat
       

        // 18. feladat
        Console.Write("K�rek egy pozit�v eg�sz sz�mot: ");
        int n = int.Parse(Console.ReadLine());
        int osszeg = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                osszeg += i;
            }
        }
        Console.WriteLine("Oszt�k �sszege: " + osszeg);

        // 19. feladat
        Console.Write("K�rek egy pozit�v eg�sz sz�mot: ");
        n = int.Parse(Console.ReadLine());
        osszeg = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                osszeg += i;
            }
        }
        if (osszeg == 2 * n)
        {
            Console.WriteLine("T�k�letes sz�m.");
        }
        else
        {
            Console.WriteLine("Nem t�k�letes sz�m.");
        }

        // 20. feladat
        Console.Write("Hatv�nyalap: ");
        int alap = int.Parse(Console.ReadLine());
        Console.Write("Kitev�: ");
        int kitevo = int.Parse(Console.ReadLine());
        int hatvany = 1;
        for (int i = 0; i < kitevo; i++)
        {
            hatvany *= alap;
        }
        Console.WriteLine("Hatv�ny�rt�k: " + hatvany);

        // 21. feladat
        int pozitiv;
        do
        {
            Console.Write("K�rek egy pozit�v sz�mot: ");
            pozitiv = int.Parse(Console.ReadLine());
        } while (pozitiv <= 0);
        Console.WriteLine("A beolvasott sz�m: " + pozitiv);

        // 22. feladat
        int szam, osszeg2 = 0;
        do
        {
            Console.Write("K�rek egy sz�mot: ");
            szam = int.Parse(Console.ReadLine());
            if (szam < 10)
            {
                osszeg2 += szam;
            }
        } while (szam < 10);
        Console.WriteLine("A beolvasott sz�mok �sszege: " + osszeg2);

        // 23. feladat
        Console.Write("K�rek egy eg�sz sz�mot: ");
        int szorzatSzam = int.Parse(Console.ReadLine());
        int eredeti = szorzatSzam;
        Console.Write(eredeti + " = ");
        bool voltKettes = false;
        while (szorzatSzam % 2 == 0)
        {
            Console.Write("2*");
            szorzatSzam /= 2;
            voltKettes = true;
        }
        Console.WriteLine(szorzatSzam);
        
        static void Main()
        {
            // 24. feladat 
            string szo;
            do
            {
                Console.Write("K�rek egy sz�t: ");
                szo = Console.ReadLine();
            } while (szo != "alma");
            Console.WriteLine("Az alma gy�m�lcs!");

            // 25. feladat
            Console.Write("K�rek egy eg�sz sz�mot: ");
            int szam = int.Parse(Console.ReadLine());
            int eredeti = szam;
            int hanyszor = 0;
            while (szam >= 3)
            {
                szam -= 3;
                hanyszor++;
            }
            Console.WriteLine($"{eredeti} = {hanyszor}*3+{szam}");
        }
    }

}

 