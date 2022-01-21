class Rac
{
    public int num, den;
    public Rac(int x, int y)
    {
        num = x;
        den = y;
    }
    public static Rac operator +(Rac a, Rac b)
    {
        Rac result;
        int c = a.num, d = b.num, e = a.den;
        if (a.den != b.den)
        {
            c *= b.den;
            d *= a.den;
            e *= b.den;
        }
        result = new(c + d, e);
        return result;
    }
    public static Rac operator -(Rac a, Rac b)
    {
        Rac result;
        int c = a.num, d = b.num, e = a.den;
        if (a.den != b.den)
        {
            c *= b.den;
            d *= a.den;
            e *= b.den;
        }
        result = new(c - d, e);
        return result;
    }
    public static Rac operator *(Rac a, Rac b)
    {
        Rac result;
        result = new(a.num * b.num, a.den * b.den);
        return result;
    }
    public static Rac operator /(Rac a, Rac b)
    {
        Rac result;
        result = new(a.num * b.den, a.den * b.num);
        return result;
    }
    public string Text()
    {
        string text;
        text = $"{num}/{den}";
        return text;
    }
}