using System;

class Program
{
    static void Main(string[] args)
    {
    //all of what is being listed here actually calls to the functions in the "fraction.cs" file.
        // this line creates a new instance of the "fraction" function, with default values for _top and _bottom.
        Fraction f1 = new Fraction();
        // this line writes out what is being calculated with the values from f1 (this will print 1/1)
        Console.WriteLine(f1.GetFractionString());
        //this line prints the calculation of the two values, by converting the values from an integer, into a double.
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}