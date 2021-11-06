using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class ChallengeCLI
    {
        [TestMethod]
        public void MainEntry_Valid()
        {
            Assert.AreEqual(0, Program.Main(new string[] { "--numbers", "1", "2", "3", "4", "5", "--target", "5" }));
        }

        [TestMethod]
        public void MainEntry_MissingTargetParameter()
        {
            Assert.AreEqual(1, Program.Main(new string[] { "--numbers", "1", "2", "3", "4", "5" }));
        }

        [TestMethod]
        public void MainEntry_MissingNumbersParameter()
        {
            Assert.AreEqual(1, Program.Main(new string[] { "--target", "5" }));
        }
    }
}
