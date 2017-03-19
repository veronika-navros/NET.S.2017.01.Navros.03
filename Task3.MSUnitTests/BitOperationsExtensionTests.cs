using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.MSUnitTests
{
    [TestClass]
    public class BitOperationsExtensionTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            @"Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"|DataDirectory|\\Task3_OK.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem(@"Task3.MSUnitTests\\Task3_OK.xml")]
        [TestMethod]
        public void InsertByPosition_InsertBitsOfNumber2IntoNumber1()
        {
            int number1 = Convert.ToInt32(TestContext.DataRow["Number1"]);
            int number2 = Convert.ToInt32(TestContext.DataRow["Number2"]);
            int startPosition = Convert.ToInt32(TestContext.DataRow["StartPosition"]);
            int endPosition = Convert.ToInt32(TestContext.DataRow["EndPosition"]);

            var expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            var actual = BitOperationsExtension.InsertByPosition(number1, number2, startPosition, endPosition);

            Assert.AreEqual(expected, actual);
        }

        [DataSource(
            @"Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"|DataDirectory|\\Task3_ArgumentException.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem(@"Task3.MSUnitTests\\Task3_ArgumentException.xml")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertByPosition_ThrowsArgumentException()
        {
            int number1 = Convert.ToInt32(TestContext.DataRow["Number1"]);
            int number2 = Convert.ToInt32(TestContext.DataRow["Number2"]);
            int startPosition = Convert.ToInt32(TestContext.DataRow["StartPosition"]);
            int endPosition = Convert.ToInt32(TestContext.DataRow["EndPosition"]);

            var actual = BitOperationsExtension.InsertByPosition(number1, number2, startPosition, endPosition);
        }
    }
}
