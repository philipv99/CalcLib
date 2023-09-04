
using System.Numerics;

public class Claculator
{
    /// <summary>
    /// adds to numbers, and returns a double
    /// </summary>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    /// <returns></returns>
    public static double Plus(double n1, double n2)
    {
        return n1 + n2;
    }

    public static double Plus(int n1, int n2)
    {
        Convert.ToDouble(n1);
        Convert.ToDouble(n2);

        return n1 + n2;
    }

    public static double Minus(double n1, double n2)
    {
        return n1 - n2;
    }
    public static double Multiply(double n1, double n2)
    {
        return n1 * n2;
    }
    public static double Devid(double n1, double n2)
    {
        return n1 / n2;
    }

    /// <summary>
    /// calculate acording to char:ops (opetator) (+ , - , * , /)
    /// </summary>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    /// <param name="ops"></param>
    /// <returns>double</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double Calc(double n1, double n2, char ops )
    {
        if (ops == null) { throw new ArgumentNullException(nameof(ops)); }
        switch (ops) 
        {
            case '+': return Plus(n1, n2);
            case '-': return Minus(n1, n2);
            case '*': return Multiply(n1, n2);
            case '/': return Devid(n1, n2);
            default: throw new ArgumentException("charrector not acceptet");
        }
    }
}