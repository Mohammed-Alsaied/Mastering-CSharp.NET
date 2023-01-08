//Employee e1 = new Employee
//{
//    Id = 1,
//    Name = "Mohamed",
//    Salary = 1000m,
//    Department = "IT"
//};

//Employee e2 = new Employee
//{
//    Id = 1,
//    Name = "Mohamed",
//    Salary = 1000m,
//    Department = "IT"
//};
//Employee e3 = e1;
////Console.WriteLine(e1 == e2);//references
////Console.WriteLine(e3 == e1);//references
//Console.WriteLine(e1 == e2);
//Console.WriteLine(e1.Equals(e2));//Content -> override

//Console.WriteLine(7.GetHashCode());

//var ints = new FiveIntegers(1, 2, 3, 4, 5);
//foreach (var i in ints)
//{
//    Console.WriteLine(i);
//}
var temps = new List<Tempreture>();
Random rnd = new Random();
for (var i = 0; i < 100; i++)
{
    temps.Add(new Tempreture(rnd.Next(-30, 50)));
}


temps.Sort(); //System.InvalidOperationException: Failed to compare two elements in the array.
foreach (var item in temps)
{
    Console.WriteLine(item.Value);
}
class Tempreture : IComparable
{
    private int _value;
    public Tempreture(int value)
    {
        _value = value;
    }
    public int Value => _value;

    public int CompareTo(object obj)
    {
        if (obj is null)
            return 1;
        var temp = obj as Tempreture;
        if (temp is null)
            throw new ArgumentException("object is not a tempreture object");

        return this._value.CompareTo(temp._value);
    }
}