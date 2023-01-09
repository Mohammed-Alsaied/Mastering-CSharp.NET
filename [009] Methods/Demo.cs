public class Demo
{
    // Method Syntax
    // <AccessMOdifiers>  <DataType>/ void  MethodeName (Parameter List)
    //{
    // // series of statment
    //}

    #region Void Func
    //public void DoSomeThing()
    //{
    //    System.Console.WriteLine("Do Some Thing....");
    //}
    // age is Parameter

    //value type Parameter
    //public void DoSomeThing(int age)
    //{
    //    age = age + 3;
    //}
    ////public void DoSomeThing(ref int age)
    ////{
    ////    age = age + 3;
    //}

    //public void DoSomeThing(out int age)
    //{
    //    age = 18; // assign age in Func only not at caller
    //    age = age + 3;
    //}
    #endregion

    #region Return Type Func

    // Callee
    //public int DoSomeThing()
    //{
    //    var x = 100;
    //    return x * x;
    //}
    #endregion

    #region Method Signature
    // methode signature (Name + Param Typr + Patam Order + no od Param)

    // Method Overloading (A common way of implementation Polymorphism)
    //public void DoSomeThing(int x, double y)
    //{

    //}

    //public void DoSomeThing(double x, int y)
    //{

    //}


    #region Ex: Methods Without Overloading
    //public void PromoteIncrease(double amount)
    //{
    //    System.Console.WriteLine($"you have apromotion of ${amount}");
    //}

    //public void PromoteIncreaseAndTicket(double amount, string trip)
    //{
    //    System.Console.WriteLine($"you have apromotion of ${amount} and a trip {trip}");
    //}

    //public void PromoteIncreaseAndTicketAndHotel(double amount, string trip, string hotel)
    //{
    //    System.Console.WriteLine($"you have apromotion of ${amount} and a trip {trip},and a hotel {hotel}");
    //}
    #endregion


    #region Ex: Methods With Overloading
    public void Promote(double amount)
    {
        System.Console.WriteLine($"you have apromotion of ${amount}");
    }

    public void Promote(double amount, string trip)
    {
        System.Console.WriteLine($"you have apromotion of ${amount} and a trip {trip}");
    }

    public void Promote(double amount, string trip, string hotel)
    {
        System.Console.WriteLine($"you have apromotion of ${amount} and a trip {trip},and a hotel {hotel}");
    }
    #endregion

    #endregion

    #region Expresion Bodies Method without body

    //public bool IsEven(int number)
    //{
    //    return number % 2 == 0;
    //}

    //public bool IsEven(int number) => number % 2 == 0; // 1 statment

    #endregion

    #region Local Methods
    //public void PrintEven(int[] original)
    //{
    //    foreach (var n in original)
    //    {
    //        if (IsEven(n))
    //        {
    //            System.Console.WriteLine(n + " ");
    //        }
    //    }

    //    bool IsEven(int number) => number % 2 == 0; // Local Method 
    //}


    #endregion

    #region Static Method
    //public static void PrintEven(int[] original)
    //{
    //    foreach (var n in original)
    //    {
    //        if (IsEven(n))
    //        {
    //            System.Console.WriteLine(n + " ");
    //        }
    //    }

    //    //2.local methode is ok
    //    static bool IsEven(int number) => number % 2 == 0; // Local Method 
    //}
    #endregion

    #region Local Method
    //1. public static bool IsEven(int number) => number % 2 == 0; // Local Method 
    #endregion


}