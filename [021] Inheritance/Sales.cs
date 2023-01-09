namespace _021__Inheritance
{
    public class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesVolume;
            this.Commission = commission;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }

        public decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }


        public override string ToString()
        {
            return base.ToString() +
               $"\nCommission: ${Commission}" +
                $"\nBonus: ${CalculateBonus()}" +
               $"\nNet Salary: ${this.Calculate()}";
        }

    }
}
