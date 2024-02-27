using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YourUnitTestProject
{
    public class YourClass
    {
        public static int MethodToTest(int a)
        {
            return 5;
        }
        public static string MethodToTest(string a)
        {
            return "stroka";
        }
        public static bool MethodToTest(bool a)
        {
            return false;
        }
    }
    [TestClass]
    public class YourTestClass
    {
        [TestMethod]
        public void NumericValues_ShouldMatch()
        {
            // Arrange
            int expected = 5;
            int actual = YourClass.MethodToTest(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TextValues_ShouldMatch()
        {
            // Arrange
            string expected = "stroka";
            string actual = YourClass.MethodToTest("j");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExceptionHandling_ShouldReturnFalse()
        {
            // Arrange

            // Act
            bool result = YourClass.MethodToTest(false);

            // Assert
            Assert.IsFalse(result);
        }
    }
}