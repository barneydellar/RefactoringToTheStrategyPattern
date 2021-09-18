using System.Drawing;
using Moq;
using NUnit.Framework;

namespace StrategyCSharp
{
    public class WidgetTest
    {
        [Test]
        public void AWidgetCanBeCreated()
        {
            Widget w = new Widget();
        }

        [Test]
        public void AWidgetCanDescribeItself()
        {
            Widget w = new Widget();
            w.Describe();
        }

        [Test]
        public void AWidgetStartsAsATriangle()
        {
            Widget w = new Widget();
            Assert.True(w.Describe() == "Triangle");
        }

        [Test]
        public void AWidgetSTypeCanBeChangedAtRunTime()
        {
            Widget w = new Widget();
            Assert.True(w.Describe() == "Triangle");
            w.SetType(Type.Square);

            Assert.True(w.Describe() == "Square");
        }

        [Test]
        public void AWidgetCanSetToBeATriangle()
        {
            Widget w = new Widget();
            w.SetType(Type.Triangle);
        }

        [Test]
        public void ATriangularWidgetDescribesItselfAsATriangle()
        {
            Widget w = new Widget();
            w.SetType(Type.Triangle);

            Assert.True(w.Describe() == "Triangle");
        }

        [Test]
        public void ATriangularWidgetDrawsAsATriangle()
        {
            Widget w = new Widget();
            w.SetType(Type.Triangle);

            var c = new Mock<ICanvas>();

            w.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(It.IsAny<Point>()), Times.Exactly(3));
        }

        [Test]
        public void AWidgetCanSetToBeASquare()
        {
            Widget w = new Widget();
            w.SetType(Type.Square);
        }

        [Test]
        public void ASquareWidgetDescribesItselfAsASquare()
        {
            Widget w = new Widget();
            w.SetType(Type.Square);

            Assert.True(w.Describe() == "Square");
        }

        [Test]
        public void ASquareWidgetDrawsAsASquare()
        {
            Widget w = new Widget();
            w.SetType(Type.Square);

            var c = new Mock<ICanvas>();

            w.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(It.IsAny<Point>()), Times.Exactly(4));
        }

        [Test]
        public void AWidgetCanSetToBeAPentagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Pentagon);
        }

        [Test]
        public void APentagonWidgetDescribesItselfAsAPentagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Pentagon);

            Assert.True(w.Describe() == "Pentagon");
        }

        [Test]
        public void APentagonWidgetDrawsAsAPentagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Pentagon);

            var c = new Mock<ICanvas>();

            w.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(It.IsAny<Point>()), Times.Exactly(5));
        }

        [Test]
        public void AWidgetCanSetToBeAHexagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Hexagon);
        }

        [Test]
        public void AHexagonWidgetDescribesItselfAsAHexagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Hexagon);

            Assert.True(w.Describe() == "Hexagon");
        }

        [Test]
        public void AHexagonWidgetDrawsAsAHexagon()
        {
            Widget w = new Widget();
            w.SetType(Type.Hexagon);

            var c = new Mock<ICanvas>();

            w.Draw(c.Object);

            c.Verify(mock => mock.DrawVertex(It.IsAny<Point>()), Times.Exactly(6));
        }
    }
}