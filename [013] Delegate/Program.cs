using _013__Delegate;

public delegate void RectDelegate(decimal width, decimal height);//no body ,same segnature of function,Maintanabil at long term
public class Program
{
    static void Main(string[] args)
    {
        var Emps = new Employee[]
        {
                new Employee {Id=1,Name="Issam A",Gender="M",TotalSales=65000m},
                new Employee {Id=2,Name="Reem S",Gender="F",TotalSales=50000m},
                new Employee {Id=3,Name="Suzan B",Gender="F",TotalSales=65000m},
                new Employee {Id=4,Name="Sara A",Gender="F",TotalSales=40000m},
                new Employee {Id=5,Name="Salah C",Gender="M",TotalSales=42000m},
                new Employee {Id=6,Name="Rateb A",Gender="M",TotalSales=30000m},
                new Employee {Id=7,Name="Abeer C",Gender="F",TotalSales=16000m},
                new Employee {Id=8,Name="Marawan M",Gender="M",TotalSales=15000m},

        };

        #region Lambda Expression(=>)
        //var report = new Report();
        //report.ProcessEmployee(Emps, "Sales >= $60,000", e => e.TotalSales >= 60000);
        //report.ProcessEmployee(Emps, "Sales Between $30,000 $59,000", e => e.TotalSales >= 30000m && e.TotalSales < 60000m);
        //report.ProcessEmployee(Emps, "Sales <= $30,000", e => e.TotalSales < 30000m);

        //report.ProcessEmployee(Emps, "Sales >= $60,000", (Employee e) => e.TotalSales >= 60000);
        //report.ProcessEmployee(Emps, "Sales Between $30,000 $59,000", (Employee e) => e.TotalSales >= 30000m && e.TotalSales < 60000m);
        //report.ProcessEmployee(Emps, "Sales <= $30,000", (Employee e) => e.TotalSales < 30000m);
        #endregion

        #region With Multicast Delegate
        var helper = new RectangeHelper();
        RectDelegate rect;
        rect = helper.GetArea;
        rect += helper.GetPerimeter;
        rect(10, 10);

        rect -= helper.GetArea;
        Console.WriteLine("after unsubscribing rect.GetArea");
        rect(10, 10);
        #endregion

        #region Without Multicast Delegate
        //helper.GetArea(10, 10);
        //helper.GetPerimeter(10, 10);
        #endregion

        Console.ReadKey();

        #region With Anonymous Delegate
        //var report = new Report();
        //report.ProcessEmployee(Emps, "Sales >= $60,000", delegate (Employee e) { return e.TotalSales >= 60000; });
        //report.ProcessEmployee(Emps, "Sales Between $30,000 $59,000", delegate (Employee e) { return e.TotalSales >= 30000m && e.TotalSales < 60000m; });
        //report.ProcessEmployee(Emps, "Sales <= $30,000", delegate (Employee e) { return e.TotalSales < 30000m; });

        //Console.ReadKey();

        #endregion

        #region Without Anonymous Delegate

        //var report = new Report();
        //    report.ProcessEmployee(Emps, "Sales >= $60,000", IsSalesGraterThenOrEqual60000);
        //    report.ProcessEmployee(Emps, "Sales Between $30,000 $59,000", IsSalesBetween30000And60000);
        //    report.ProcessEmployee(Emps, "Sales <= $30,000", IsSalesLessThen30000);

        //    Console.ReadKey();
        //}



        //static bool IsSalesGraterThenOrEqual60000(Employee e) => e.TotalSales >= 60000m;
        ////{
        ////    return e.TotalSales >= 60000;
        ////}
        //static bool IsSalesBetween30000And60000(Employee e) => e.TotalSales >= 30000m && e.TotalSales < 60000m;
        ////{
        ////    return e.TotalSales >= 60000;
        ////}
        //static bool IsSalesLessThen30000(Employee e) => e.TotalSales < 30000m;
        ////{
        ////    return e.TotalSales >= 60000;
        ////}

        #endregion
    }
}

public class RectangeHelper
{
    public void GetArea(decimal width, decimal height)
    {
        var result = width * height;
        Console.WriteLine($"Area:{width} x {height} = {result}");
    }

    public void GetPerimeter(decimal width, decimal height)
    {
        var result = 2 * (width + height);
        Console.WriteLine($"Perrmeter:2 x ({width} + {height}) = {result}");
    }
}