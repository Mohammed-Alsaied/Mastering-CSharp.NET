//public delegate bool Filter(int n);//Delegate

//public delegate bool Filter<in T>(T n);//Generic Delegate

class Program
{
    static void Main(string[] args)
    {
        #region Generic Delegate


        //    IEnumerable<int> list1 = new int[] { 2, 5, 6, 4, 7, 8, 9, 1, 3, };

        //    Console.WriteLine($"Numbers Less Than 6\n");

        //    PrintNumbers(list1, n => n < 6);//Annonymos Delegate

        //    Console.WriteLine($"Numbers Less Than 7\n");
        //    PrintNumbers(list1, n => n < 7);

        //    Console.WriteLine($"Even Numbers\n");
        //    PrintNumbers(list1, n => n % 2 == 0);


        //    IEnumerable<decimal> list2 = new decimal[] { 2.23m, 5.36m, 6.647m, 4.364m, 7.987m, 8.47m, 9.254m, 1.10m, 3.62m, };

        //    Console.WriteLine($"Numbers grater Than 1.10\n");
        //    PrintNumbers(list2, n => n > 1.10m);

        //}



        //static void PrintNumbers<T>(IEnumerable<T> numbers, Filter<T> filter)
        //{
        //    foreach (var n in numbers)
        //    {
        //        if (filter(n))
        //        {
        //            Console.WriteLine(n);
        //        }


        //    }
        //}
        #endregion

        #region Generic Built in Delegate
        /*
         * Action
         * Func
         * Predicate
         */

        Action<string> action = Print; // no return type
        action("Mohamed");
        Func<int, int, int> addD = Add;//one return type
        Console.WriteLine(addD(2, 2));
        Predicate<int> predicate = IsEven;// bool return type
        Console.WriteLine(predicate(3));


        IEnumerable<int> list1 = new int[] { 2, 5, 6, 4, 7, 8, 9, 1, 3, };



        PrintNumbers(list1, n => n < 6, () => Console.WriteLine($"Numbers Less Than 6\n"));//Annonymos Delegate

        PrintNumbers(list1, n => n < 7, () => Console.WriteLine($"Numbers Less Than 7\n"));

        PrintNumbers(list1, n => n % 2 == 0, () => Console.WriteLine($"Even Numbers\n"));

        IEnumerable<decimal> list2 = new decimal[] { 2.23m, 5.36m, 6.647m, 4.364m, 7.987m, 8.47m, 9.254m, 1.10m, 3.62m, };

        PrintNumbers(list2, n => n > 1.10m, () => Console.WriteLine($"Numbers grater Than 1.10\n"));

    }



    //static void PrintNumbers<T>(IEnumerable<T> numbers, Predicate<T> filter)
    //{
    //    foreach (var n in numbers)
    //    {
    //        if (filter(n))
    //        {
    //            Console.WriteLine(n);
    //        }


    //    }
    //}

    static void PrintNumbers<T>(IEnumerable<T> numbers, Func<T, bool> filter, Action action)
    {
        action();
        foreach (var n in numbers)
        {
            if (filter(n))
            {
                Console.WriteLine(n);
            }


        }
    }

    static void Print(string name) => Console.WriteLine(name);
    static int Add(int n1, int n2) => n1 + n2;
    static bool IsEven(int n) => n % 2 == 0;
    #endregion
}

//static void PrintNumbersLessThanpivotNumber(IEnumerable<int> numbers, int pivotNumber)
//{
//    foreach (var n in numbers)
//    {
//        if (n < pivotNumber)
//        {
//            Console.WriteLine(n);
//        }


//    }
//}


//static void PrintNumbersLessThanSix(IEnumerable<int> numbers)
//{
//    foreach (var n in numbers)
//    {
//        if (n < 6)
//        {
//            Console.WriteLine(n);
//        }


//    }
//}


//static void PrintNumbersLessThanSeven(IEnumerable<int> numbers)
//{
//    foreach (var n in numbers)
//    {
//        if (n < 7)
//        {
//            Console.WriteLine(n);
//        }


//    }
//}