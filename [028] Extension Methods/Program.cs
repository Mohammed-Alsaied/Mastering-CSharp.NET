namespace _028__Extension_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region DateTime
            //DateTime dt = DateTime.Now;
            //Console.WriteLine($"DateTime.Now: {dt}");
            //dt = new DateTime(2023, 1, 11, 0, 0, 0);
            //Console.WriteLine($"DateTime.Now: {dt}");
            #endregion DateTime

            #region DateTimeOffset

            //DateTimeOffset dts = DateTimeOffset.Now;
            //Console.WriteLine($"DateTime.Now: {dts}");

            //dts = DateTimeOffset.UtcNow;
            //Console.WriteLine($"DateTime.UtcNow: {dts}");
            #endregion DateTimeOffset

            #region Using Date Time Helper
            //TimeSpan ts = new TimeSpan(2, 30, 0);
            //dt = dt.Add(ts);
            //Console.WriteLine($"DateTime.Now: {dt}");
            //Console.WriteLine($"Is weekend: {DateTimeHelper.IsWeekEnd(dt)}");
            //Console.WriteLine($"Is weekday: {DateTimeHelper.IsWeekDay(dt)}");

            //dt = dt.AddDays(5);
            //Console.WriteLine($"DateTime.Now: {dt}");

            //Console.WriteLine(DateTimeHelper.IsWeekEnd(dt));
            //Console.WriteLine($"Is weekday: {DateTimeHelper.IsWeekDay(dt)}");
            #endregion Using Date Time 

            #region Extension Methods Notes
            /*
             * add this keyworf before instance type in () for function.
             * a clas and function must be static.
             */
            #endregion

            #region Using Date Time Extension Methods
            //TimeSpan ts = new TimeSpan(2, 30, 0);
            //dt = dt.Add(ts);
            //Console.WriteLine($"DateTime.Now: {dt}");
            //Console.WriteLine($"Is weekend: {dt.IsWeekEnd()}");
            //Console.WriteLine($"Is weekday: {dt.IsWeekDay()}");

            //dt = dt.AddDays(5);
            //Console.WriteLine($"DateTime.Now: {dt}");

            //Console.WriteLine(dt.IsWeekEnd());
            //Console.WriteLine($"Is weekday: {dt.IsWeekDay()}");
            #endregion Using Date Time Helper

            //Console.WriteLine($"Is Leap Year: {DateTime.IsLeapYear(2024)}");

            Pizza p = new Pizza();

            //p = PizzaExtensions.AddDough(PizzaExtensions.AddSauce(PizzaExtensions.AddCheeze(PizzaExtensions.AddCToppings(p, "black olives", 3.5m), true)), "thin");
            p.AddDough("thin")
                .AddSauce()
                .AddCheeze(true)
                .AddCToppings("black olives", 3.5m);
            System.Console.WriteLine(p);
        }


    }

    #region Example

    static class PizzaExtensions
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"{type} Dough X $4.00";
            value.TotalPrice += 4m;
            return value;
        }

        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"Tomato Sause X $2.00";
            value.TotalPrice += 2m;
            return value;
        }

        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"{(extra ? "extre" : "regular")} Cheeze Sause X ${(extra ? "6.00" : "4.00")}";
            value.TotalPrice += extra ? 6m : 4m;
            return value;
        }

        public static Pizza AddCToppings(this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.TotalPrice += price;
            return value;
        }
    }

    class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }

        public Pizza AddSauce()
        {
            this.Content += $"Barpecue Sause X $2.00";
            this.TotalPrice += 2m;
            return this;
        }
        public override string ToString()
        {
            return $"{Content}\n......................\nTotla Price: ${TotalPrice.ToString("#.##")}";
        }
    }


    #endregion Example
}
