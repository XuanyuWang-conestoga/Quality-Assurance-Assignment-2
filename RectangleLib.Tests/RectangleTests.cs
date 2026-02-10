using NUnit.Framework;
using RectangleLib;

namespace RectangleLib.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        private Rectangle testRectangle;

        [SetUp]
        public void Setup()
        {
            testRectangle = new Rectangle();
        }

        // -------------- Test for GetWidth --------------
        [Test]
        public void GetWidth_DefaultConstructor_Return1()
        {
            // Arrange
            Rectangle defaultRetangle = new Rectangle();
            int expected = 1;

            // Act
            int actual = defaultRetangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetWidth_NonDefaultConstructorWithWidth111_Return111()
        {
            // Arrange
            Rectangle nonDefaultRetangle = new Rectangle(111, 11);
            int expected = 111;

            // Act
            int actual = nonDefaultRetangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetWidth_SetWidth88_Return88()
        {
            // Arrange
            Rectangle defaultRetangle = new Rectangle();
            defaultRetangle.SetWidth(88);
            int expected = 88;

            // Act
            int actual = defaultRetangle.GetWidth();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        // -------------- Test for SetWidth --------------
        [Test]
        public void SetWidth_Input99_Return99()
        {
            // Arrange
            int width = 99;
            int expected = width;

            // Act
            int actual = testRectangle.SetWidth(width);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetWidth_Input1500_Return1500()
        {
            // Arrange
            int width = 1500;
            int expected = width;

            // Act
            int actual = testRectangle.SetWidth(width);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SetWidth_Input9999_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int width = 9999;
            Exception expected = new ArgumentOutOfRangeException("Width must be between 1 and 1500");

            // Act
            TestDelegate act = () => testRectangle.SetWidth(width);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        // -------------- Test for GetPerimeter --------------
        [Test]
        public void GetPerimeter_DefaultConstructor_Return4()
        {
            // Arrange
            Rectangle defaultRectangle = new Rectangle();
            int expected = 4;

            // Act
            int actual = defaultRectangle.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPerimeter_NonDefaultConstructorWidth10Length20_Return60()
        {
            // Arrange
            Rectangle nonDefaultRectangle = new Rectangle(10, 20);
            int expected = 60;

            // Act
            int actual = nonDefaultRectangle.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPerimeter_MaxBoundaryValues_Return6000()
        {
            // Arrange
            Rectangle maxRectangle = new Rectangle(1500, 1500);
            int expected = 6000;

            // Act
            int actual = maxRectangle.GetPerimeter();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // -------------- Test for GetArea --------------
        [Test]
        public void GetArea_DefaultConstructor_Return1()
        {
            // Arrange
            Rectangle defaultRectangle = new Rectangle();
            int expected = 1;

            // Act
            int actual = defaultRectangle.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetArea_NonDefaultConstructorWidth10Length20_Return200()
        {
            // Arrange
            Rectangle nonDefaultRectangle = new Rectangle(10, 20);
            int expected = 200;

            // Act
            int actual = nonDefaultRectangle.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetArea_MaxBoundaryValues_Return2250000()
        {
            // Arrange
            Rectangle maxRectangle = new Rectangle(1500, 1500);
            int expected = 2250000;

            // Act
            int actual = maxRectangle.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}
