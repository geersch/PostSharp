namespace Calculator
{
    public interface ICalculator
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
        double Divide(int x, int y);
    }
}