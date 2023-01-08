#region Exception Definition
//var result = BadMethode();//exception. System.DivideByZeroException
//Console.WriteLine(result);
//try
//{
//    var result = BadMethode();
//    Console.WriteLine(result);
//}
//catch (Exception ex) when (ex.Source == "Exception")//filtring > C#6
//{
//    //handle Exception
//    Console.WriteLine("cannot divide by zero");
//}
//finally
//{
//    Console.WriteLine("End");
//}
//static int BadMethode()
//{
//    var x = 2;
//    var y = 0;
//    return x / y;
//}

#endregion

#region Example

public enum DeliverySatues
{
    UNKNOWN,
    PROCESSED,
    SHIPPED,
    INTRANSIT,
    DELIVRED
}



#endregion