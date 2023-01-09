namespace _008__Field_And_Constant
{
    public class Employee
    {
        //<ClassMOdifier> -> public,internal (default),private
        //<ClassMOdifier> Class <Class Name>
        //{
        // Class Block
        //}

        //Class Members
        //Fields
        //Constants
        //Properties
        //Methods
        //Events
        //Operation
        //Indexres
        //Constructor
        //Finalyzer
        //Nested Types

        //<AccessModifiers> public,private,protected
        //Constant -> <AccessModifiers> const <DataType>  <ConstName = <Value>
        //public const double TAX = 0.03;
        public static double TAX = 0.03;

        // FIelds -> <AccessModifier>  <DataType>  <FieldName = <InitialValue>

        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        private double Calaculate() => Wage * LoggedHours;

        private double CalculateTax() => Calaculate() * TAX;

        private double CalculateNet() => Calaculate() - CalculateTax();

        internal string PrintSlip()
        {


            return $"\nFirst Name: {FName}" +
            $"\nLast Name: {LName}" +
            $"\nWage: {Wage}" +
            $"\nLoggedHours: {LoggedHours}" +
            "\n----------------------------------" +
            $"\nSalary: {Calaculate()}" +
            $"\nDeducatable Tax: ({Employee.TAX * 100} Amount: ${CalculateTax()})" +
            $"\nNet Salary: {CalculateNet()}\n";
        }
    }
}
