namespace _013__Delegate
{
    public class Report
    {
        #region With Delegate
        public delegate bool Iligibale(Employee e);
        public void ProcessEmployee(Employee[] employee, string title, Iligibale iligibale)
        {
            System.Console.WriteLine(title);
            System.Console.WriteLine("-----------------------------------");

            foreach (var e in employee)
            {
                if (iligibale(e))//bool
                {
                    System.Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }

            System.Console.WriteLine("\n\n");
        }

        #endregion

        #region Withote Delegate
        //public void ProcessEmployeeWith60000PlusSales(Employee[] employee)
        //{
        //    System.Console.WriteLine("Empolyees With $60,000+ Sales");
        //    System.Console.WriteLine("-----------------------------------");

        //    foreach (var e in employee)
        //    {
        //        if (e.TotalSales >= 60000M)
        //        {
        //            System.Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }

        //    System.Console.WriteLine("\n\n");
        //}


        //public void ProcessEmployeeWithSalesBetween30000PAnd590000(Employee[] employee)
        //{
        //    System.Console.WriteLine("Empolyees With Sales Betwwen $30,000 And  $59,000+ Sales");
        //    System.Console.WriteLine("-----------------------------------");

        //    foreach (var e in employee)
        //    {
        //        if (e.TotalSales < 60000M && e.TotalSales > 30000M)
        //        {
        //            System.Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }

        //    System.Console.WriteLine("\n\n");
        //}

        //public void ProcessEmployeeWithSalesLessThan30000P(Employee[] employee)
        //{
        //    System.Console.WriteLine("Empolyees With Sales Less Than $30,000 Sales");
        //    System.Console.WriteLine("-----------------------------------");

        //    foreach (var e in employee)
        //    {
        //        if (e.TotalSales < 30000M)
        //        {
        //            System.Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
        //        }
        //    }

        //    System.Console.WriteLine("\n\n");
        //}
        #endregion
    }
}
