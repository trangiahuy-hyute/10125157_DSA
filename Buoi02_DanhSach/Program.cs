using System;
using System.Numerics;

class Program
{
    // Bai 1: Tim kiem nhi phan
    static void Bai1()
    {
        int[] a = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };

        Console.Write("Nhap so can tim: ");
        int x = int.Parse(Console.ReadLine());

        int left = 0;
        int right = a.Length - 1;
        int vitri = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (a[mid] == x)
            {
                vitri = mid;
                break;
            }
            else if (a[mid] < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (vitri != -1)
            Console.WriteLine("Tim thay tai vi tri: " + vitri);
        else
            Console.WriteLine("Khong tim thay!");
    }

    // Bai 2: Kiem tra so nguyen to
    static bool KiemTra2(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Bai2()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTra2(n))
        {
            Console.WriteLine(n + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(n + " khong phai la so nguyen to");
        }
    }

    // Bai 3: Tim so hoan hao
    static bool SoHoanHao(int n)
    {
        int tong = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                tong += i;
            }
        }

        return tong == n;
    }

    static void Bai3()
    {
        Console.Write("Nhap N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i < N; i++)
        {
            if (SoHoanHao(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    // Bai 4: Fibonacci
    static void Bai4()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < n; i++)
        {
            BigInteger c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine("Fibonacci = " + a);
    }

    // Bai 5: Sap xep noi bot
    static void Bai5()
    {
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        double[] a = new double[n];

        // Nhap mang
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}] = ", i);
            a[i] = double.Parse(Console.ReadLine());
        }

        // Sap xep noi bot
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    double temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        // Xuat mang sau khi sap xep
        Console.WriteLine("Day sau khi sap xep tang dan:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
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
    }
}
