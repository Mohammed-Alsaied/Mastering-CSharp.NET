

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

using System.Collections;

class FiveIntegers : IEnumerable
{
    int[] _values;

    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in _values)
        {
            yield return item;
        }
    }

    #region Before yield
    //public IEnumerator GetEnumerator() => new Enumerator(this);

    //class Enumerator : IEnumerator
    //{
    //    int currentIndex = -1;
    //    FiveIntegers _integers;

    //    public Enumerator(FiveIntegers integers)
    //    {
    //        _integers = integers;
    //    }

    //    public object Current
    //    {
    //        get
    //        {
    //            if (currentIndex == -1)
    //                throw new InvalidOperationException($"Enumeration not started");
    //            if (currentIndex == _integers._values.Length)
    //                throw new InvalidOperationException($"Enumeration has started");
    //            return _integers._values[currentIndex];
    //        }
    //    }

    //    public bool MoveNext()
    //    {
    //        if (currentIndex >= _integers._values.Length - 1)
    //            return false;
    //        return ++currentIndex < _integers._values.Length;
    //    }

    //    public void Reset() => currentIndex = -1;
    //}

    #endregion


}