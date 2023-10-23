namespace MyCalculator.Classes;

public class Calculator()
{
    public int Add(params int[] p)
    {
        int s = 0;
        foreach(int i in p)
        {
            s += i;
        }
        return s;
    }
}