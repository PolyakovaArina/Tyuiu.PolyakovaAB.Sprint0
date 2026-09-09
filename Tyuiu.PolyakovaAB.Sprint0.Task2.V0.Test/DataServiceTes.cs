using Tyuiu.PolyakovaAB.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PolyakovaAB.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTes

    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Arina";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Arina", res);

        }
    }
}
