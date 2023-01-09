internal class Program
{
    static void Main(string[] args)
    {
        //var p = new Person();
        //p.Name = "Mohamed";
        //System.Console.WriteLine(p.Name);
        MakeSomeGarbage();
        Console.WriteLine($"Memory Used Before Collection: {GC.GetTotalMemory(false):N0}");
        GC.Collect();//Explicit Cleaning
        Console.WriteLine($"Memory Used Before Collection: {GC.GetTotalMemory(true):N0}");
    }

    static void MakeSomeGarbage()
    {
        Version v;

        for (int i = 0; i < 1000; i++)
        {
            v = new Version();
        }
    }
}



//Finalizer = Destructor
//When Object Get Disposed
//1.End of Program Excution(implist)
//2.Memory Full(implist)
//3.GC.Collect(Explist)

class Person
{
    public string Name { get; set; }

    public Person()
    {
        System.Console.WriteLine("The Person Constructor");
    }

    ~Person()
    {
        System.Console.WriteLine("The Person Destructor");

    }
}