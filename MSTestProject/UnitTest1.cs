namespace MSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string statecode = "OH";
            // Act
            string statename = UnitTestDemo.BusinessFunctions.GetStateName(statecode);
            // Assert
            Assert.AreEqual(statename, "Ohio");
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string statecode = "XX";
            // Act
            string statename = UnitTestDemo.BusinessFunctions.GetStateName(statecode);
            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string statecode = "";
            // Act
            string statename = UnitTestDemo.BusinessFunctions.GetStateName(statecode);
            // Assert
            Assert.AreEqual(statename,"");
        }
    }
}