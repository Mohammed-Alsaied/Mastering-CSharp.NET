public static class Extensions
{
    public static void Print<T>(this T[] source)
    {
        if (!source.Any())
        {
            System.Console.WriteLine("{}");
            return;
        }

        System.Console.WriteLine("{");
        for (var i = 0; i < source.Length; i++)
        {
            System.Console.WriteLine($"{source[i]}");
            System.Console.WriteLine(i < source.Length - 1 ? ", " : "");

        }
        System.Console.WriteLine("}");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        #region Single Dim.Array
        // fixed array of numbers,referncetype address stored at stack and value stored at heap
        // single Dim.Array
        //1. Declaration
        //string[] friends = new string[5];//friends stored at stack,5 stored at heap

        //// 2. Accessing Element
        //friends[0] = "Ali";
        //friends[1] = "Reem";
        //friends[2] = "Faisel";
        //friends[3] = "Ahmed";
        //friends[4] = "Abeer";

        //friends.Print();

        //3.Intialization V1
        //string[] friends = new string[5] // can use var here
        //{
        //    "ALi",
        //    "Reem",
        //    "Faisel",
        //    "Ahmed",
        //    "Abeer",

        //};

        //3.Intialization V2
        //string[] friends = //Explicity Defining Data Type
        //{
        //    "ALi",
        //    "Reem",
        //    "Faisel",
        //    "Ahmed",
        //    "Abeer",

        //};
        //friends.Print();
        #endregion

        #region Multi Dim.Array (Rectangular Array) 
        //// suduko,chess
        //int[,] suduko =
        //{

        //    {9,8,7,6,5,4,3,2,1},
        //    {1,2,3,4,5,6,7,8,9},
        //    {1,5,9,7,5,3,7,8,9}
        //};



        #endregion

        #region Jagged Array (array inside array)
        // high performance
        //var jagged = new int[][]
        //{
        //    new int []{1,2},
        //    new int []{2,5,6},
        //    new int []{7},


        //};

        #endregion

        #region Indices And Ranges C# 8
        //var friends = new string[] { "ALi", "Reem", "Faisel", "Ahmed", "Abeer", };

        //var first = friends[0];
        //System.Console.WriteLine(first);//Ali

        //var slice1 = friends[..2];//from 0 to 2 Exceclusive 2
        //slice1.Print();

        //var slice2 = friends[2..];//scaped first 2
        //slice2.Print();



        //var slice3 = friends[2..^2];// staring after 2 take from last 1,2
        //slice3.Print();

        //var sliceRange = 2..^2;
        //var slice1 = friends[sliceRange]; // new Array Best Performance used Span
        //slice1.Print();

        #endregion

        #region BoundS of Checks
        var friends = new string[] { "ALi", "Reem", "Faisel", "Ahmed", "Abeer", };
        var item = friends[5];
        System.Console.WriteLine(item);

        #endregion

    }
}