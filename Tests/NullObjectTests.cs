using DesignPatterns.NullObject;

namespace Tests
{
    public class NullObjectTests
    {
        [Fact]
        public void GetEmpployeeNull()
        {
            var employee = DB.GetEmployee("Bob");
            if (employee.IsTimeToPay(DateTime.Today))
                Assert.Fail("failed");
            Assert.Same(employee, Employee.NULL);
        }

        [Fact]
        public void GetEmpployeeSuccess()
        {
            var employee = DB.GetEmployee("Carlos");
            if (employee.IsTimeToPay(DateTime.Today))
                employee.Pay();
            Assert.NotSame(employee, Employee.NULL);
        }
    }
}
