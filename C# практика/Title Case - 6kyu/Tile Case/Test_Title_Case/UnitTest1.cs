using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tile_Case;

namespace Test_Title_Case
{
    [TestClass]
    public class SolutionTest
    {        
        [TestMethod]
        public void MyTest2()
        {
            Assert.AreEqual("", Kata.TitleCase(""));
        }
        [TestMethod]
        public void MyTest3()
        {
            Assert.AreEqual("The Quick Brown Fox", Kata.TitleCase("the quick brown fox"));
        }
    }
}
