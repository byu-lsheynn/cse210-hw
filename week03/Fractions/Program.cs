using System;

class Program
{
    
    static void Main(string[] args)
    {
        string getString;
        double getDecimal;
        
        // W03 Learning Activity: Encapsulation
        Fraction f1 = new Fraction();
        getString = f1.GetFractionString();
        Console.WriteLine(getString);

        getDecimal = f1.GetDecimalValue();
        Console.WriteLine(getDecimal);

        Fraction f2 = new Fraction(5);
        getString = f2.GetFractionString();
        Console.WriteLine(getString);

        getDecimal = f2.GetDecimalValue();
        Console.WriteLine(getDecimal);

        Fraction f3 = new Fraction(3, 4);
        f3.GetFractionString();
        Console.WriteLine(getString);

        getDecimal = f3.GetDecimalValue();
        Console.WriteLine(getDecimal);

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);
        getString = f4.GetFractionString();
        Console.WriteLine(getString);

        getDecimal = f4.GetDecimalValue();
        Console.WriteLine(getDecimal);
    }
}