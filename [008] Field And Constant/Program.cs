using _008__Field_And_Constant;

public class Program
{
    const double TAX = 0.03;

    static void Main(string[] args)

    {
        //Massy
        //string[] fName;
        //string[] lName;


        //System.Console.Write("First Name: ");
        //var fName = System.Console.ReadLine();

        //System.Console.Write("Last Name: ");
        //var lName = System.Console.ReadLine();

        //System.Console.Write("Wage: ");
        //var wage = Convert.ToDouble(Console.ReadLine());


        //System.Console.Write("LoggedHours: ");
        //var loggedHours = Convert.ToDouble(Console.ReadLine());

        //var netSalary = wage * loggedHours - (wage * loggedHours * TAX);

        //Console.WriteLine($"First Name: {fName}");
        //Console.WriteLine($"Last Name: {lName}");
        //Console.WriteLine($"Wage: {wage}");
        //Console.WriteLine($"LoggedHours: {loggedHours}");
        //Console.WriteLine($"Net Salary: {netSalary}");



        // Object Syntax
        // Declaration <Type> <ObjectName>;
        // Assignment <ObjectName> = new <Type>();
        // Initialization <Type> <ObjectName> = new <Type>();

        //Object stored in stack & value stored in heap

        Employee[] emps = new Employee[2];
        Employee e1 = new Employee();
        Console.WriteLine("First Employee\n");



        System.Console.Write("First Name: ");
        e1.FName = System.Console.ReadLine();

        System.Console.Write("Last Name: ");
        e1.LName = System.Console.ReadLine();

        System.Console.Write("Wage: ");
        e1.Wage = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("LoggedHours: ");
        e1.LoggedHours = Convert.ToDouble(Console.ReadLine());


        Employee e2 = new Employee();
        Console.WriteLine("Seconde Employee\n");
        System.Console.Write("First Name: ");
        e2.FName = System.Console.ReadLine();

        System.Console.Write("Last Name: ");
        e2.LName = System.Console.ReadLine();

        System.Console.Write("Wage: ");
        e2.Wage = Convert.ToDouble(Console.ReadLine());


        System.Console.Write("LoggedHours: ");
        e2.LoggedHours = Convert.ToDouble(Console.ReadLine());


        emps[0] = e1;

        emps[1] = e2;

        foreach (var emp in emps)
        {
            var netSalary = emp.Wage * emp.LoggedHours - (emp.Wage * e1.LoggedHours * Employee.TAX);
            Console.WriteLine($"First Name: {emp.FName}");
            Console.WriteLine($"Last Name: {emp.LName}");
            Console.WriteLine($"Wage: {emp.Wage}");
            Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
            Console.WriteLine($"Net Salary: {netSalary}");
        }





    }
}