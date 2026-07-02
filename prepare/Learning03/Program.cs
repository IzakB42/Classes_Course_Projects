using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int i=0;
        Fraction fraction1 = new Fraction(1);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2= new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3= new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4= new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Fraction fraction5 = new Fraction();
        do
        {
            Random rnd = new Random();
            int top = rnd.Next();
            int bottom = rnd.Next();
            fraction5.SetTop(top);
            fraction5.SetBottom(bottom);
            string fraction5_string= fraction5.GetFractionString();
            double fdecimal= fraction5.GetDecimalValue();
            Console.WriteLine($"Fraction {i+1}: string: {fraction5_string} Number: {fdecimal}");
            i+=1;
        }while(i<=19);

    }       
}

