using _021__Inheritance;

class Program
{
    static void Main(string[] args)
    {
        //var e = new Eagle();
        //e.Move();

        //Animal a = new Animal();
        ////a.Move();
        //a.Name = "Eagls";
        //Console.WriteLine(a);

        //Eagle e = new Eagle();
        //Console.WriteLine(e.GetType());

        //SubClass sc = new SubClass(123);

        Manager m = new Manager(1000, "Mohamed", 180, 10);

        Maintanance ms = new Maintanance(1001, "Ahmed", 182, 8);

        Sales s = new Sales(1002, "Saly", 176, 9, 0.05m, 1000m);

        Developer d = new Developer(1003, "Mohamed Al Saeed", 186, 15, true);

        Employee[] employees = { m, ms, s, d };

        foreach (var employee in employees)
        {
            Console.WriteLine("\n ---------");
            Console.WriteLine(employee);
        }

        //var sc = new SubClass();
        //Console.WriteLine(sc.value);
    }
}

#region Why Inheritance?
//Reusability
//Maintainability
//Extensibility

#endregion

#region Inheritance Restricted
//1.class can inhirit from only a single class
//but can itself be inherite by many classes

//2.Sealed Key word
#endregion

#region Chiled Class Cannot Access to Protected Members out side it Class
//Eagle e = new Eagle();
//e.Move();

#endregion

#region Conversion

#region UPCASTING
//Creates a base class reference from a subclass reference
//var e = new Eagle();
//Animal a = e;
//a.Move();
#endregion

#region DOWNCASTING
//Creates a  subclass  reference from a base class reference
//Eagle e2 = (Eagle)a; //Exeblicty
//e2.Fly();
//e2.Move();

#endregion

#region Using as Key Word
//var e = new Eagle();
//Animal a = e;
////Falcon f = (Falcon)a; // System.InvalidCastException: Unable to cast object of type 'Inheritance.Eagle' to type 'Inheritance.Falcon'.
//Falcon f = a as Falcon; //Null

#endregion

#region Using if
//var e = new Eagle();
//Animal a = e;
//if (a is Falcon)
//{
//    Console.WriteLine("a is a Falcon");
//}
//else
//{
//    Console.WriteLine("a is not Falcon");
//}
#endregion
#endregion

#region Abstract Class
//abstract class Animal
//{


//    public void Move()
//    {
//        Console.WriteLine("Moving");
//    }
//}

//var a = new Animal(); //Cannot be Instantiate it Direct
#endregion

#region Sealed Class
//sealed class Eagle : Animal //Cann Access to public and protected members inside class not outside
//{
//    public void Fly()
//    {
//        Console.WriteLine("Flying");
//    }

//    public void SomeMethode()
//    {
//        Move();
//    }

//}

//class AmericanEagle : Eagle //cannot derive from sealed type
//{

//}

#endregion

#region Polymorphism & abstract class & Virtual Members sealed Members
//abstract class Animal
//{
//    //public virtual void Move()
//    //{
//    //    Console.WriteLine("Moving");
//    //}

//    public abstract void Move();

//}

////Abstract Members VS Virtual Members
////Abstract Members -> No Virtual Implementation
////Virtual Members -> has Virtual Implementation
//class Eagle : Animal
//{
//    //public override void Move()
//    //{
//    //    //base.Move();
//    //    //Move();
//    //    Console.WriteLine("The Eagel");

//    public sealed override void Move()
//    {
//        //base.Move();
//        //Move();
//        Console.WriteLine("The Eagel");

//    }

//    //this-> Keyword call class members
//    //base-> Keyword call base class members
//    public void SomeMethode()
//    {
//        Move();
//    }


//}

//class AmericanEagle : Eagle
//{

//    //public override void Move() //cannot override inherited member because it is sealed
//    //{
//    //    Console.WriteLine("thw American Eagle Moving");
//    //}


//}
#endregion

#region Object Class
//class Animal
//{
//    //automatically inhirit Object Class (Base)
//    public string Name { get; set; }
//    public void Move()
//    {
//        Console.WriteLine($"Animal: {Name} is Moving");
//    }

//    public override string ToString()
//    {
//        return $"Animal: {Name}";
//    }
//}

//class Eagle : Animal
//{

//}

#endregion

#region Constructor & Inheritance
//class BaseClass
//{
//    public int x;

//    public BaseClass()
//    {

//    }

//    public BaseClass(int value)
//    {
//        x = value;
//    }
//}

//class SubClass : BaseClass
//{
//    public SubClass(int scValue) : base(scValue)
//    {

//    }

//}

#endregion

#region Hiding Inherited Members
//class Baseclass
//{
//    public int value = 10;

//}

//class SubClass : Baseclass
//{
//    public new int value = 20;
//}
#endregion