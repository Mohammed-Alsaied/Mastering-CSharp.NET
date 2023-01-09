class Program
{
    static void Main(string[] args)
    {
        //    Date d1 = new Date(29, 02, 2000);
        //    //d1.Day = 01;
        //    //d1.Month = 01;
        //    //d1.Year = 0001;

        //    Date d2 = new Date(2000);
        //    Date d3 = new Date(12, 2000);


        //    Console.WriteLine(d1.GetDate());

        //    Console.WriteLine(d2.GetDate());

        //    Console.WriteLine(d3.GetDate());


        //Employee e1 = new Employee();
        //e1.Id = 1;
        //e1.FName = "Mohamed";
        //e1.LName = "Al Saeed";

        ////Object Initializer
        //Employee e2 = new Employee
        //{
        //    Id = 1,
        //    FName = "Mohamed",
        //    LName = "Al Saeed"
        //};

        //Employee e3 = new Employee(1000)
        //{

        //    FName = "Mohamed",
        //    LName = "Al Saeed"
        //};

        Employee e1 = Employee.Create(100, "Mohamed", "Al Saeed");


        //Object Initializer


        Console.WriteLine(e1.DisplayName());


    }

}

//public class Date
//{
//    //readonly ->donot modifing out side constructor or in assign field
//    private static readonly int[] DaysToManth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//    private static readonly int[] DaysToManth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


//    //private int dayMonth;
//    //private int _dayMonth;
//    private readonly int year;
//    private readonly int month;
//    private readonly int day;

//    //<AccessModifiers> <TypeName> (<paramerts list>)

//    //Default/Implicit Costructor
//    public Date()
//    {

//    }

//    public Date(int year) : this(01, 01, year)
//    {

//    }

//    public Date(int month, int year) : this(01, month, year)
//    {

//    }
//    public Date(int day, int month, int year)
//    {
//        var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

//        if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
//        {
//            int[] days = isLeap ? DaysToManth366 : DaysToManth365;
//            if (day >= 1 && day <= days[month])
//            {
//                this.day = day;
//                this.month = month;
//                this.year = year;
//            }
//            else
//            {
//                this.day = 01;
//                this.month = 01;
//                this.year = 01;
//            }
//        }
//        else
//        {

//            this.day = 01;
//            this.month = 01;
//            this.year = 01;
//        }




//    }
//    public string GetDate()
//    {
//        return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
//    }
//}

public class Employee
{

    private Employee(int id, string fName, string lName)
    {
        this.Id = id;
        this.FName = fName;
        this.LName = lName;

    }

    public static Employee Create(int id, string fName, string lName)
    {
        return new Employee(id, fName, lName);
    }
    private int Id;
    private string? FName;
    private string? LName;

    //public Employee(int id)
    //{
    //    Id = id;
    //}

    //public Employee()
    //{

    //}

    public string DisplayName()
    {
        return $"Id {Id} Name: {FName} {LName}";
    }
}