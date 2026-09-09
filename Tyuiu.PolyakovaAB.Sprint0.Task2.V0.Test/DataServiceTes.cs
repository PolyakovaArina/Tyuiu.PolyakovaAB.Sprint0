using Tyuiu.PolyakovaAB.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PolyakovaAB.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTes

    {
        [TestMethod]
        public void CheckYelloValid()
        {
            var name = "Arina";
            var result = DataService.GetHello(name);

            Assert.AreEqual("Hello, Arina!", result);

        }
    }
}
