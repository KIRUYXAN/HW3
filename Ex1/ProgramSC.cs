struct ComplexS
{
    public double re, im;
    public ComplexS(double a, double b)
    {
        re = a;
        im = b;
    }
    public string Text()
    {
        string text;
        if (im < 0) text = $"{re} - {-im}i";
        else text = $"{re} + {im}i";
        return text;
    }
    public static ComplexS operator +(ComplexS z1, ComplexS z2)
    {
        ComplexS result;
        result = new(z1.re + z2.re, z1.im + z2.im);
        return result;
    }
    public static ComplexS operator -(ComplexS z1, ComplexS z2)
    {
        ComplexS result;
        result = new(z1.re - z2.re, z1.im - z2.im);
        return result;
    }
}

class ComplexC
{
    public double re, im;
    public ComplexC(double a, double b)
    {
        re = a;
        im = b;
    }
    public string Text()
    {
        string text;
        if (im < 0)  text = $"{re} - {-im}i";
        else text = $"{re} + {im}i";
        return text;
    }
    public static ComplexC operator +(ComplexC z1, ComplexC z2)
    {
        ComplexC result;
        result = new(z1.re + z2.re, z1.im + z2.im);
        return result;
    }
    public static ComplexC operator -(ComplexC z1, ComplexC z2)
    {
        ComplexC result;
        result = new(z1.re - z2.re, z1.im - z2.im);
        return result;
    }
    public static ComplexC operator *(ComplexC z1, ComplexC z2)
    {
        ComplexC result;
        result = new((z1.re*z2.re)-(z1.im*z2.im), (z1.re*z2.im)+(z1.im*z2.re));
        return result;
    }
}