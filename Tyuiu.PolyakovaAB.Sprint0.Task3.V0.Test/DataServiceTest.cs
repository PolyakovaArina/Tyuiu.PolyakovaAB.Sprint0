using Tyuiu.PolyakovaAB.Sprint0.Task3.V0.Lib;
namespace Tyuiu.PolyakovaAB.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSumValid()
        {
            var a = 5;
            var b = 5;
            var result = DataService.Sum(a, b);

            Assert.AreEqual(10, result);
        }
    }
}
