namespace _021__Inheritance
{
    public class Employee
    {
        protected const int MinimumLoggedHours = 176;
        protected const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }

        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        protected virtual decimal Calculate()
        {

            return CalaculateBaseSalary() + CalculateOverTime();
        }

        private decimal CalaculateBaseSalary()
        {
            return LoggedHours * Wage;
        }

        private decimal CalculateOverTime()
        {
            var additianalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);

            return additianalHours * Wage * OverTimeRate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.", "");
            return $"" +
                $"{type}" +
                $"\nId: {Id}" +
                $"\nName: {Name}" +
                $"\nLogged Hours: {LoggedHours} hrs" +
                $"\nWage : ${Wage}/hr" +
                $"\nBase Salary : ${CalaculateBaseSalary()}" +
                $"\nOvertime : ${CalculateOverTime()}";

        }
    }
}
