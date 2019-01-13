using Multiplier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MultiplierTests
{
    [TestClass]
    public class MultiplierUnitTest
    {
        [TestMethod]
        public void MultiplyTwoInts_5_7_Returns_35_using_Mock()
        {
            // Arrange
            // create a Mock object of the INTERFACE
            var mockMultiplierUtils = new Mock<IMultiplierUtils>();

            // set up the mock object so it returns specified ints
            // (we don't want the test asking the user for Console inputs!)
            mockMultiplierUtils.Setup(m => m.MyInteger).Returns(5);
            mockMultiplierUtils.Setup(m => m.MyMultiplier).Returns(7);

            // create an object of the type that contains the method-under-test,
            // by using the Mock object to instantiate it
            var testResultObj = new Multiply(mockMultiplierUtils.Object);

            // define the expected test result
            var expectedResponse = 35;


            // Act
            // calculate the response from the method-under-test
            // (the Mock object's values are used)
            var response = testResultObj.MultiplyTwoInts();
            

            // Assert
            Assert.AreEqual(expectedResponse, response);
        }
    }
}
