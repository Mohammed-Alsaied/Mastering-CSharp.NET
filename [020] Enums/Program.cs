class Program
{

    #region Notes
    //Enums ->Strongly Typed Named Constant
    //Value Type
    //Default Type Int
    //use Explicit to change type supported data type(Long - byte,sbyte)
    //Unsupported String
    //Enum is Abstract Class
    //case senestive
    //Code Readability
    //Easy to use
    //Manuplate it External by string
    //Manuplate it Internal by int
    //less Memorey Consumed

    #endregion

    #region Before Using Enums

    //const int i = 10;
    //const int Jan = 1;
    //const int Feb = 2;
    #endregion

    #region After Using Enums

    #region Simple Enum

    static void Main(string[] args)
    {
        //Console.WriteLine(Month.FEB);
        //Console.WriteLine((int)Month.FEB);
        //Console.WriteLine(Month.FEB.ToString());

        //var day = "feb";//error case senestive
        //var day = "FEB";
        //var day = 2;

        #region Using  Parse
        //Console.WriteLine(Enum.Parse(typeof(Month), day));
        #endregion

        #region Using  TryParse with 

        //if (Enum.TryParse(day, out Month month))
        //{
        //    Console.WriteLine(month);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entry");
        //}
        #endregion

        #region Using  IsDefined with string
        //if (Enum.IsDefined(typeof(Month), day))
        //{
        //    Console.WriteLine(Enum.Parse(typeof(Month), day));
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entry");
        //}
        #endregion

        #region Useing  IsDefined with int
        //if (Enum.IsDefined(typeof(Month), day))
        //{
        //    Console.WriteLine((Month)day);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Entry");
        //}
        #endregion

        #region Enum Loop  With GetNames
        //foreach (var month in Enum.GetNames(typeof(Month)))
        //{
        //    Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)}");
        //}
        #endregion

        #region Enum Loop  With GetValues
        foreach (var month in Enum.GetValues(typeof(Month)))
        {
            Console.WriteLine($"{month.ToString()} = {(int)month}");
        }
        #endregion

        Console.WriteLine();


    }


    enum Month
    {
        JAN = 1,    //Index 0
        FEB,        //Index 1
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }
    #endregion

    #region Flags Enum
    //static void Main(string[] args)
    //{
    //    var day = (DAY.SATURDAY | DAY.SUNDAY);

    //    if (day.HasFlag(DAY.WEEKEND))
    //    {
    //        Console.WriteLine("enjoy your weekend");
    //    }

    //}

    [Flags]
    enum DAY
    {
        NONE = 0b_0000_0000, //0
        MONDAY = 0b_0000_0001,//1
        TUESDAY = 0b_0000_0010,//2
        WEDNESDAY = 0b_0000_0100,//4
        THURSDAY = 0b_0000_1000, //8
        FRIDAY = 0b_0001_0000,  //16
        SATURDAY = 0b_0010_0000,//32 
        SUNDAY = 0b_0100_0000,  //64
        BUSDAY = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,
        WEEKEND = SATURDAY | SUNDAY // 0b_0110_0000
    }
    #endregion

    #endregion


















}
