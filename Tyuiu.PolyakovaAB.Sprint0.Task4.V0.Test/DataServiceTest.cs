using Tyuiu.PolyakovaAB.Sprint0.Task4.V0.Lib;
namespace Tyuiu.PolyakovaAB.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubstractionalVoid()
        {
            Assert.AreEqual(0, DataService.Substraction(5, 5));
        }
        [TestMethod]
        public void CheckMultiplicationVoid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }
        [TestMethod]
        public void CheckDivisionVoid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}
