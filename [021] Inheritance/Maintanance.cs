namespace _021__Inheritance
{
    public class Maintanance : Employee
    {
        private const decimal Hardship = 100m;

        public Maintanance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }

        private decimal CalculateAllowance()
        {
            return base.Calculate() * Hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
               $"\nHardship: ${CalculateAllowance()}" +
               $"\nNet Salary: ${this.Calculate()}";
        }

    }
}
