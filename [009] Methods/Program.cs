using _008__Field_And_Constant;

public class Program
{
    static void Main(string[] args)
    {
        #region Employee Class
        //static & cons called by Class Name not by instance
        //Static can changed at execution
        //Const Cannot Changed
        Employee[] emps = new Employee[2];

        Console.Write("TAX");
        Employee.TAX = Convert.ToDouble(Console.ReadLine());// cannot use static
                                                            //stored in high frequency Heap
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

        //foreach (var emp in emps)
        //{
        //    var salary = emp.Wage * emp.LoggedHours;
        //    var taxAmount = salary * Employee.TAX;
        //    var netSalary = salary - taxAmount;


        //    Console.WriteLine($"\nFirst Name: {emp.FName}");
        //    Console.WriteLine($"Last Name: {emp.LName}");
        //    Console.WriteLine($"Wage: {emp.Wage}");
        //    Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
        //    Console.WriteLine("----------------------------------");
        //    Console.WriteLine($"Salary: {salary}");
        //    Console.WriteLine($"Deducatable Tax: ({Employee.TAX * 100} Amount: ${salary})");
        //    Console.WriteLine($"Net Salary: {netSalary}\n");


        //}

        foreach (var emp in emps)
        {
            System.Console.WriteLine(emp.PrintSlip());
        }
        #endregion

        #region Demo Class
        //Demo d1 = new Demo();
        //Caller
        //d1.DoSomeThing();// move to Function for Exucution
        //var z = 100 + d1.DoSomeThing();//Primary Exp;

        // value type argument passed
        //var age = 18;
        //d1.DoSomeThing(age);// 18
        //System.Console.WriteLine(age);//18 value type passed take compy frome memory
        // 18 is the argument Passed

        //ref type argument passed
        //var age = 18;
        //int age = 0;// must has a intial value to use ref
        //d1.DoSomeThing(ref age);// 18
        //System.Console.WriteLine(age);

        // suing out key word if a argument Passed has intial value
        //int age = 0;// must has a intial value to use ref
        //d1.DoSomeThing(out age);// 18
        //System.Console.WriteLine(age);

        // Ex: Out
        //var numString = "123456S";
        //var numString = "123456";

        //if (!int.TryParse(numString, out int number)) // set value at numString to number
        //{
        //    System.Console.WriteLine("Invalid Number");
        //}
        //else
        //{
        //    System.Console.WriteLine($"you provided a valid number{number}");
        //}

        //Methods With Overloading
        //d1.Promote(100, "Amman", "San");

        //var result = d1.IsEven(6);
        //System.Console.WriteLine(result);

        //loca Methods
        //var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //Demo.PrintEven(numbers);




        #endregion
    }


}
