#region Interface Notes
/*
 *include Behavior only no fields 
 *Deffines a Contract
 *Can inhirit more interfaces
 *Implicit Implementatin
 *Explicit Implementatin
 *Default Public Access Modifiers
 */
#endregion

#region Interface Intruduction & Implicit Implementatin
//Vehicle v1 = new Honda("Honda", "Civic", 2021);
//Honda v2 = new Honda("Honda", "Accord", 2021);
//ILoader v3 = new Caterpillar("Caterpillar", "Cat1", 2023);

//abstract class Vehicle //abstract type
//{
//    protected string Brand;
//    protected string Model;
//    protected int Year;
//    public Vehicle(string brand, string model, int year)
//    {
//        Brand = brand;
//        Model = model;
//        Year = year;
//    }





//}

//interface iDrivable
//{
//    void Move();
//    void Stop();
//}
//interface ILoader
//{
//    void Load();
//    void Unload();
//}
//class Honda : Vehicle //concrete
//{
//    public Honda(string brand, string model, int year)
//        : base(brand, model, year)
//    {
//    }
//}

//class Caterpillar : Vehicle, ILoader, iDrivable
//{
//    public Caterpillar(string brand, string model, int year)
//        : base(brand, model, year)
//    {
//    }

//    public void Load()
//    {
//        Console.WriteLine("Loading");
//    }

//    public void Move()
//    {
//        Console.WriteLine("Move");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Stop");

//    }

//    public void Unload()
//    {
//        Console.WriteLine("Un Loading");

//    }
//}
#endregion

#region  Interface Explicit  Implementatin
//IMove m = new Vehicle();
//m.Move();
//m.Turn();
//class Vehicle : IMove, IDisplace
//{
//    void IMove.Move()
//    {
//        Console.WriteLine("IMove move");
//    }

//    void IDisplace.Move()
//    {
//        Console.WriteLine("IDisplace move");
//    }
//}
//interface IMove
//{
//    //Default Implementaion after C#8
//    void Turn()
//    {
//        Console.WriteLine("turning");
//    }
//    void Move();
//}

//interface IDisplace
//{
//    void Move();
//}
#endregion

#region Interface Real World Project
//Tight Coupling VS Loos Coupling
//Tight Coupling-> Means one class is Dependennt on another class
//Loos Coupling->Means one class is Dependennt on Interface rather than class
Cashier c = new Cashier(new Cash());
c.Checkout(99999.99m);

Cashier c1 = new Cashier(new MasterCard());
c1.Checkout(99999.99m);
class Cashier
{
    private IPayment _payment;

    public Cashier(IPayment payment)
    {
        _payment = payment;
    }



    public void Checkout(decimal amount)
    {
        _payment.Pay(amount);
    }
}

interface IPayment
{
    void Pay(decimal amount);
}
class Cash : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Cash Payment: ${Math.Round(amount, 2)}");
    }
}


class Debit : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Debit Payment: ${Math.Round(amount, 2)}");
    }
}

class Visa : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Visa Payment: ${Math.Round(amount, 2)}");
    }
}

class MasterCard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"MasterCard Payment: ${Math.Round(amount, 2)}");
    }
}
#endregion