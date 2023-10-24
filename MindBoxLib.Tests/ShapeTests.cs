namespace MindBoxLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_20_Return_1256_6()
        {
            Circle circle = new Circle("Circle", 20);
            double expected = 1256.6;

            double result = circle.Square();

            Assert.AreEqual(expected, result);
        }
    }
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Square_5_7_11_Return_13()
        {
            Triangle triangle = new Triangle("Triangle", 5,7,11);
            double expected = 13;

            double result = triangle.Square();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void isRectangular_ReturnFalse()
        {
            var triangle = new Triangle("Triangle", 2, 3, 4);

            var result = triangle.isRectangular();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void isRectangular_ReturnTrue()
        {
            var triangle = new Triangle("Triangle", 3, 4, 5);

            var result = triangle.isRectangular();

            Assert.IsTrue(result);
        }
    }

}