public class BuggyLogic
{
    public int Calcular(int a, int b)
    {
        if (a == 0)
        {
            return b * 2;
        }

        if (b == 0)
        {
            return a * 2;
        }

        return (a * b); 
    }
}
