


//Console.WriteLine(e1 == e2);//references
//Console.WriteLine(e3 == e1);//references

//var s1 = "Hello";
//var s2 = "Hello";
//Console.WriteLine(s1 == s2);
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public string Department { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
            return false;

        var emp = obj as Employee;

        return this.Id == emp.Id
               && this.Name == emp.Name
               && this.Salary == emp.Salary
               && this.Department == emp.Department;
    }

    public override int GetHashCode()
    {
        int hash = 13;//prime numbers reduce colission
        hash = (hash * 7) + Id.GetHashCode();
        hash = (hash * 7) + Name.GetHashCode();
        hash = (hash * 7) + Salary.GetHashCode();
        hash = (hash * 7) + Department.GetHashCode();
        return hash;
    }

    public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
    public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);
}