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

public class Delivery
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public DeliverySatues DeliverySatues { get; set; }

    public override string ToString()
    {
        return $"{{\nId: {Id},\nCustomer: {CustomerName}, \nAddress: {Address}," +
            $"\nStatues: {DeliverySatues} }}";
    }
}



#endregion