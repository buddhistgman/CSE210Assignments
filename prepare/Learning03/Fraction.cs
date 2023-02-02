using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // this code makes it so that the default number for both would be 1, 
        //for example, Fraction f1 = "new Fraction();" would simply be 1/1. the format is _top/_bottom.
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        //this function makes it so that top is a whole number, by converting it to an integer, which only properly takes whole numbers,
        //as opposed to doubles and floats, which take decimals.
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        //this function simply renames top and bottom. this function uses the process of "getters and setters"
        //this is changing a private field into a public property, so that it may be called freely elsewhere
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //this function prints the values in a pleasant fashion, 
        //do note that it does not actually make a calculation, just prints out the numbers making the calculation.
                        /*string text = $"{_top}/{_bottom}";*/
        string text = _top + "/" + _bottom;
        return text;
        
    }

    public double GetDecimalValue()
    {
        //this function is the function that actually makes the calculation based on the numbers from the "GetFractionString()" function
        return (double)_top / (double)_bottom;
    }
}