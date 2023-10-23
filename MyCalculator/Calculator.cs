namespace MyCalculator.Classes;

public class Calculator()
{
    static void Main() { }

    public int Add(params int[] p)
    {
        int s = 0;
        foreach(int i in p)
        {
            s += i;
        }
        return s;
    }
    public int Subtract(params int[] p)
    {
        int s = p[0];
        for (int i = 1; i < p.Length; i++)
        {
            s -= p[i];
        }
        return s;
    }

    public int Multiply(params int[] p)
    {
        int m = 1;
        foreach (int i in p)
        {
            m *= i;
        }
        return m;
    }

    public int? Divide(params int[] p)
    {
        int d = p[0];
        for (int i = 0; i < p.Length - 1; i++)
        {
            if (p[i + 1] == 0)
            {
                return null;
            }
            d /= p[i + 1]; 
        }
        return d;
    }
}