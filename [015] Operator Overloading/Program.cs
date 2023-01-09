class Program
{
    static void Main(string[] args)
    {
        Money m1 = new Money(10);
        Money m2 = new Money(20);

        Console.WriteLine($"M1; ${m1.Amount} ,M2; ${m2.Amount}");


        Money m3 = m1 + m2;
        Console.WriteLine($"M3: ${m3}");

        Money m4 = m2 - m1;
        Console.WriteLine($"M3: ${m4}");
        Console.WriteLine($"M2++: {(++m2).Amount}");

    }
}

class Money
{
    private decimal _amount;
    public decimal Amount => _amount;//Get

    public Money(decimal value)
    {
        this._amount = Math.Round(value, 2);//Set
    }


    public static Money operator +(Money m1, Money m2)
    {
        var value = m1.Amount + m2.Amount;
        return new Money(value);
    }

    public static Money operator -(Money m1, Money m2)
    {
        var value = m1.Amount - m2.Amount;
        return new Money(value);
    }

    public static bool operator >(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;

    }

    public static bool operator <(Money m1, Money m2)
    {
        return m1.Amount < m2.Amount;
    }

    public static bool operator >=(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;

    }

    public static bool operator <=(Money m1, Money m2)
    {
        return m1.Amount < m2.Amount;
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;

    }

    public static bool operator !=(Money m1, Money m2)
    {
        return m1.Amount != m2.Amount;
    }

    public static Money operator ++(Money m1)
    {
        var value = m1.Amount;
        return new Money(++value);
    }

    public static Money operator --(Money m1)
    {
        var value = m1.Amount;
        return new Money(--value);
    }

}
