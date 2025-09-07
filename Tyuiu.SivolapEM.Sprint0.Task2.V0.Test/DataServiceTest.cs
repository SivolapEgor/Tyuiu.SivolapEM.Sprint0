using Tyuiu.SivolapEM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SivolapEM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет Егор", res);
        }
    }
}
