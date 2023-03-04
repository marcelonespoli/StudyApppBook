namespace DesignPatterns.NullObject
{
    public class Driver : Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override bool IsTimeToPay(DateTime time)
        {
            return true;
        }

        public override void Pay()
        {
            // Make the payment
        }
    }
}
