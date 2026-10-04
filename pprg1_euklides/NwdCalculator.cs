using System;

public static class NwdCalculator
{
    public static int Nwd(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentOutOfRangeException("Liczby muszą być dodatnie.");
        }
        while (b != 0)
        {
            int reszta = a % b;
            a = b;
            b = reszta;
        }
        return a;
    }

    public static int Silnia(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException("Silnia nie jest zdefiniowana dla liczb ujemnych.");
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }
        int wynik = 1;
        for (int i = 2; i <= n; i++)
        {
            wynik *= i;
        }
        return wynik;
    }
}
