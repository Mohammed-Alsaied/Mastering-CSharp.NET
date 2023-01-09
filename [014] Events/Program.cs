public class Program //Client // Subscriber
{
    static void Main(string[] args)
    {
        var stock = new Stock("Amazon");
        stock.Price = 100;
        //stock.OnPriceChanged += Stock_OnPriceChanged;

        #region By Use Lambda Expression
        stock.OnPriceChanged += (Stock sstock, decimal oldprice) =>
        {
            string result = "";
            if (sstock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "Up";
            }
            else if (oldprice > sstock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "Down";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;



            }
            Console.WriteLine($"{sstock.Name}: ${sstock.Price} - {result}");
        };
        //Console.WriteLine($"Stock before Changing: ${stock.Price}");
        //stock.ChangeStockPriceBy(0.05m);
        //Console.WriteLine($"Stock After Changing: ${stock.Price}");

        stock.ChangeStockPriceBy(0.05m);
        stock.ChangeStockPriceBy(-0.02m);
        stock.ChangeStockPriceBy(0.00m);

        #region UnSubscriber
        //stock.OnPriceChanged -= Stock_OnPriceChanged;// UnSubscriber

        //stock.OnPriceChanged -= (Stock Stock, decimal oldprice) =>
        //{
        //    string result = "";
        //    if (Stock.Price > oldprice)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        result = "Up";
        //    }
        //    else if (oldprice > Stock.Price)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        result = "Down";

        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;



        //    }
        //    Console.WriteLine($"{Stock.Name}: ${Stock.Price} - {result}");
        //};
        //stock.ChangeStockPriceBy(-0.07m);
        //stock.ChangeStockPriceBy(-0.03m);
        #endregion

        Console.ReadKey();
    }

    #region without use Lambda Expression
    //private static void Stock_OnPriceChanged(Stock stock, decimal oldprice)

    //{
    //    string result = "";
    //    if (stock.Price > oldprice)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Green;
    //        result = "Up";
    //    }
    //    else if (oldprice > stock.Price)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Red;
    //        result = "Down";

    //    }
    //    else
    //    {
    //        Console.ForegroundColor = ConsoleColor.Gray;



    //    }
    //    Console.WriteLine($"{stock.Name}: ${stock.Price} - {result}");

    //}
}
#endregion

public delegate void StockPriceChangeHandeler(Stock stock, decimal oldprice);

public class Stock //Publisher
{
    private string name;
    private decimal price;

    public event StockPriceChangeHandeler OnPriceChanged; //Event declaretion
    public string Name => this.name;

    public decimal Price { get => this.price; set => this.price = value; }

    public Stock(string stockname)
    {
        this.name = stockname;
    }

    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldprice = this.price;

        this.price += Math.Round(this.price * percent, 2);

        if (OnPriceChanged != null)//make sure is subscriber
            OnPriceChanged(this, oldprice);// Event Firing
    }

}
#endregion