namespace _021__Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        protected bool TaskCompleted { get; set; }

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            TaskCompleted = taskCompleted;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }

        public decimal CalculateBonus()
        {
            if (TaskCompleted)
            {
                return base.Calculate() * Commission;
            }
            return 0;
        }


        public override string ToString()
        {
            return base.ToString() +
               $"\nTask Completed: {(TaskCompleted ? "Yes" : "NO")}" +
                $"\nBonus: ${CalculateBonus()}" +
               $"\nNet Salary: ${this.Calculate()}";
        }

    }
}
