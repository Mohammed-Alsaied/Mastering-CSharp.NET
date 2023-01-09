#region Before Generics
//Print(1);
//Print("Mohamed");
//Print('M');
//Print(new { FirstName = "Mohame", LastName = "Al Saeed" });
//Print(new Person { FirstName = "Mohame", LastName = "Al Saeed" });


//class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//}
//static void Print(object value)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(value);
//}

//static void Print(string value)
//{
//    Console.WriteLine(value);
//}

//static void Print(char value)
//{
//    Console.WriteLine(value);
//}
#endregion

#region Adavantages of Genrics
/*
 * Reusabilty
 * Type Safty
 * Efficiency
 */
#endregion

#region Types of Genrics
/*
 * Generic Method
 * Generic Class
 */
#endregion

#region Generic Method
//->Generic methods are methods that introduce their own type parameters. This is similar to declaring a generic type, but the type parameter's scope is limited to the method where it is declared. Static and non-static generic methods are allowed, as well as generic class constructors.

//Print(1);
//Print("Mohamed");
//Print('M');
//Print(new { FirstName = "Mohame", LastName = "Al Saeed" });
//Print(new Person { FirstName = "Mohame", LastName = "Al Saeed" });

//static void Print<T>(T value)
//{
//    Console.WriteLine($"DataType: {typeof(T)}");
//    Console.WriteLine($"DataType: {value}");
//}


//class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//}
#endregion

#region Generic Class
//->Defiend using a type parameter in an angle brackets after the class

//var numbers = new Any<int>();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.DisplayList();
//numbers.RemoveAt(1);
//numbers.DisplayList();

//var people = new Any<Person>();
using System.Collections;

var people = new List<Person>(); //Type Save

people.Add(new Person { FName = "Ali", LName = "N" });
people.Add(new Person { FName = "Mohamed", LName = "S" });

foreach (var item in people)
{
    Console.WriteLine(item);
}
//people.DisplayList();
Console.WriteLine($"Length: {people.Count} items");
Console.WriteLine($"Empty: {people.Count == 0}");

//var numbers = new Any<string>();

Console.WriteLine("------------------");
var arr = new ArrayList();// Not Type Save
arr.Add(1);
arr.Add("Good Morning ");
arr.Add(new Person { FName = "Mohamed", LName = "S" });
arr.Add(new Person { FName = "Ali", LName = "N" });
foreach (var item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Length: {arr.Count} items");
Console.WriteLine($"Empty: {arr.Count == 0}");


public class Person
{
    public string FName { get; set; }
    public string LName { get; set; }

    public override string ToString()
    {
        return $"'{FName} {LName}'";
    }
}

class Any<T> where T : class //Genreics Constrains
{
    private T[] _items;

    public void Add(T item)
    {
        if (_items is null)
        {
            _items = new T[] { item };
        }
        else
        {
            var length = _items.Length;

            var dest = new T[length + 1];
            for (int i = 0; i < length; i++)
            {
                dest[i] = _items[i];
            }
            dest[dest.Length - 1] = item;
            _items = dest;
        }

    }

    public void RemoveAt(int position)
    {
        if (position < 0 || position > _items.Length - 1)
            return;
        var index = 0;
        var dest = new T[_items.Length - 1];
        for (int i = 0; i < _items.Length; i++)
        {
            if (position == i)
                continue;
            dest[index++] = _items[i];
        }

    }

    public bool IsEmpty => _items is null || _items.Length == 0;
    public int Count => _items is null ? 0 : _items.Length;

    public void DisplayList()
    {
        Console.Write("[");
        for (int i = 0; i < _items.Length; i++)
        {
            Console.Write(_items[i]);
            if (i < _items.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]\n");
    }
}


#endregion

#region Genreics Constrains

#endregion
