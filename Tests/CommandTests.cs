using DesignPatterns.CommandEndActiveObject.Commands;

namespace Tests
{
    public class CommandTests
    {
        [Fact]
        public void Test1()
        {
            var payClassification = new SalariedClassification();
            var addEmployye = new AddEmployeeTransaction(payClassification, "Rodolfo", 1);
            addEmployye.Validate();
            addEmployye.Execute();
            Assert.Equal(2500, payClassification.MonthlyPay);
        }
    }
}