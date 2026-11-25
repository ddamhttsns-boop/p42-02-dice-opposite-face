using System;

class Program
{
    // Верните число на противоположной грани
    static int OppositeFace(int n)
    {
        return 7 - n;
    }

    static void Main()
    {
        Check(2, 5);
        Check(6, 1);
        Check(1, 6);
        Check(4, 3);
        Check(3, 4);
        Check(5, 2);
    }

    static void Check(int n, int expected)
    {
        int result = OppositeFace(n);
        string status = result == expected ? "OK" : "ОШИБКА";
        Console.WriteLine($"n = {n}: получено {result}, ожидалось {expected} - {status}");
    }
}