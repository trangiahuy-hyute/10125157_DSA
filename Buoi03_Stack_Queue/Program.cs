using System;

class Program
{
    // Bai 1: Tinh tong 1 + 2 + ... + n
    static int S1(int n)
    {
        if (n == 1)
            return 1;
        else
            return S1(n - 1) + n;
    }

    static void Bai1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong S(n) = " + S1(n));
    }

    // Bai 2: Tinh tong binh phuong
    static int S2(int n)
    {
        if (n == 1)
            return 1;
        else
            return S2(n - 1) + n * n;
    }

    static void Bai2()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong binh phuong = " + S2(n));
    }

    // Bai 3: Tinh tong nghich dao
    static double S3(int n)
    {
        if (n == 1)
            return 1;
        else
            return S3(n - 1) + 1.0 / n;
    }

    static void Bai3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong nghich dao = " + S3(n));
    }

    // Bai 4: Tinh luy thua
    static double LuyThua(double x, int n)
    {
        if (n == 0)
            return 1;
        else
            return LuyThua(x, n - 1) * x;
    }

    static double S4(double x, int n)
    {
        if (n < 0)
            return 1.0 / LuyThua(x, -n);
        else
            return LuyThua(x, n);
    }

    static void Bai4()
    {
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (x == 0 && n < 0)
            Console.WriteLine("Khong the tinh!");
        else
            Console.WriteLine("Ket qua = " + S4(x, n));
    }

    // Bai 5: Tim uoc le lon nhat
    static int UocLeMax(int n)
    {
        if (n % 2 == 1)
            return n;
        else
            return UocLeMax(n / 2);
    }

    static void Bai5()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Uoc le lon nhat = " + UocLeMax(n));
    }

    // Bai 6: Tim UCLN
    static int UCLN(int a, int b)
    {
        if (a % b == 0)
            return b;
        else
            return UCLN(b, a % b);
    }

    static void Bai6()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("UCLN = " + UCLN(a, b));
    }

    // Bai 7: Dem so chu so
    static int SoChuSo(int n)
    {
        if (n == 0)
            return 0;
        else
            return SoChuSo(n / 10) + 1;
    }

    static void Bai7()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("So chu so = " + SoChuSo(n));
    }

    // Bai 8: Tinh can long nhau
    static double Can(int i, int n)
    {
        if (i == n)
            return Math.Sqrt(n);
        else
            return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S8(int n)
    {
        return Can(1, n);
    }

    static void Bai8()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
            Console.WriteLine("Nhap n >= 1!");
        else
            Console.WriteLine("S(n) = " + S8(n));
    }

    static void Main()
    {
        Console.WriteLine("=== Bai 1 ===");
        Bai1();

        Console.WriteLine("\n=== Bai 2 ===");
        Bai2();

        Console.WriteLine("\n=== Bai 3 ===");
        Bai3();

        Console.WriteLine("\n=== Bai 4 ===");
        Bai4();

        Console.WriteLine("\n=== Bai 5 ===");
        Bai5();

        Console.WriteLine("\n=== Bai 6 ===");
        Bai6();

        Console.WriteLine("\n=== Bai 7 ===");
        Bai7();

        Console.WriteLine("\n=== Bai 8 ===");
        Bai8();
    }
}
