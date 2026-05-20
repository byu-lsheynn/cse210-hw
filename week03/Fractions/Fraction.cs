public class Fraction
{
    // Attributes declaration
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine($"Top is {_top}");
    }

    public void SetTop(int top)
    {
        _top = top;
        //Console.WriteLine($"Set top {_top}");
    }

    public void GetBottom()
    {
        Console.WriteLine($"Bottom is {_bottom}");
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
        //Console.WriteLine($"Set bottom {_bottom}");
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
        
    
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom; 
    }
}