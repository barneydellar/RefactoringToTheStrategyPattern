
using Moq;
using NUnit.Framework;

namespace StrategyCSharp
{
    class ShapeTest
    {
        [Test]
        public void AShapeCanBeCreated()
        {
            Shape s = new Shape(Type.Triangle);
        }

        [Test]
        public void AShapeCanBeDrawn()
        {
            Shape s = new Shape(Type.Triangle);
            var c = new Mock<ICanvas>();

            s.Draw(c.Object);
        }

        [Test]
        public void ATriangularShapeDrawsCorrectly()
        {
            Shape s = new Shape(Type.Triangle);
            var c = new Mock<ICanvas>();

            s.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(new Point(0, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(1, 2)), Times.Once());
        }

        [Test]
        public void ASquareShapeDrawsCorrectly()
        {
            Shape s = new Shape(Type.Square);
            var c = new Mock<ICanvas>();

            s.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(new Point(0, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 2)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(0, 2)), Times.Once());
        }

        [Test]
        public void APentagonShapeDrawsCorrectly()
        {
            Shape s = new Shape(Type.Pentagon);
            var c = new Mock<ICanvas>();

            s.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(new Point(0, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 2)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(1, 3)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(0, 2)), Times.Once());
        }

        [Test]
        public void AHexagonShapeDrawsCorrectly()
        {
            Shape s = new Shape(Type.Hexagon);
            var c = new Mock<ICanvas>();

            s.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(new Point(0, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 0)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(3, 1)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(2, 2)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(0, 2)), Times.Once());
            c.Verify(mock => mock.DrawVertex(new Point(-1, 1)), Times.Once());
        }
    }
}
