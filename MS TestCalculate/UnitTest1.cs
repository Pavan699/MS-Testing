using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;
namespace MS_TestCalculate
{
    [TestClass]
    public class UnitTest1
    {
        Operations op = new Operations();//Arrange
        [TestMethod]
        public void TestMethodAdd()
        {           
            int result = op.Add(2, 3);//act
            Assert.AreEqual(5, result);//assert
        }
        [TestMethod]
        public void TestMethodSub()
        {
            int result = op.Sub(2, 3);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethodMult()
        {
            int result = op.Mult(2, 3);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestMethodDiv()
        {
            int result = op.Div(2, 3);
            Assert.AreEqual(1, result);
        }

    }
}
