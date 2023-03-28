using ConsoleApp11;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2.5, 3.5, 6.0)]
        [DataRow(2.0, 6.2, 8.2)]
        public void TestAddMethod1(double x, double y, double expected)
        {
            // Arrange

            // Act
            double vysledek = Calc.Add(x, y);

            // Assert
            Assert.IsTrue(vysledek == expected);
        }

        [TestMethod]
        [DataRow(2.5, 0.0, 0.0)]
        [DataRow(2.0, 0.0, 0.2)]
        public void TestDivideByZeroThrowsException(double x, double y, double expected)
        {
            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => Calc.Divide(x, y));
        }
    }
}