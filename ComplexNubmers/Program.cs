class Program
{
    static void Main(string[] args)
    {
        ComplexNumber a = new ComplexNumber(2, 3);
        ComplexNumber b = new ComplexNumber(4, -1);

        ComplexNumber sum = a + b;
        ComplexNumber diff = a - b;
        ComplexNumber multiply = a * b;
        ComplexNumber divide = a / b;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"a + b = {sum}");
        Console.WriteLine($"a - b = {diff}");
        Console.WriteLine($"a * b = {multiply}");
        Console.WriteLine($"a / b = {divide}");
    }
}

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real * b.Real - a.Imaginary * b.Imaginary,
                                a.Real * b.Imaginary + a.Imaginary * b.Real);
    }

    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        return new ComplexNumber((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator,
                                (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
    }
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}