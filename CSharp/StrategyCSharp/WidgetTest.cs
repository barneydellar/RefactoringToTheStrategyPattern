using Moq;
using NUnit.Framework;

namespace StrategyCSharp;

public class WidgetTest
{
    [Test]
    public void AWidgetCanBeCreated()
    {
        // ReSharper disable once UnusedVariable
        var w = new Widget();
    }

    [Test]
    public void AWidgetCanDescribeItself()
    {
        var w = new Widget();
        w.Describe();
    }

    [Test]
    public void AWidgetStartsAsATriangle()
    {
        var w = new Widget();
        Assert.AreEqual("Triangle", w.Describe());
    }

    [Test]
    public void AWidgetSTypeCanBeChangedAtRunTime()
    {
        var w = new Widget();
        Assert.AreEqual("Triangle", w.Describe());
        w.SetType(Type.Square);

        Assert.AreEqual("Square", w.Describe());
    }

    [Test]
    public void AWidgetCanSetToBeATriangle()
    {
        var w = new Widget();
        w.SetType(Type.Triangle);
    }

    [Test]
    public void ATriangularWidgetDescribesItselfAsATriangle()
    {
        var w = new Widget();
        w.SetType(Type.Triangle);

        Assert.AreEqual("Triangle", w.Describe());
    }

    [Test]
    public void ATriangularWidgetDrawsAsATriangle()
    {
        VerifyCorrectNumberOfVertices(Type.Triangle, 3);
    }

    [Test]
    public void AWidgetCanSetToBeASquare()
    {
        var w = new Widget();
        w.SetType(Type.Square);
    }

    [Test]
    public void ASquareWidgetDescribesItselfAsASquare()
    {
        var w = new Widget();
        w.SetType(Type.Square);

        Assert.AreEqual("Square", w.Describe());
    }

    [Test]
    public void ASquareWidgetDrawsAsASquare()
    {
        VerifyCorrectNumberOfVertices(Type.Square, 4);
    }

    [Test]
    public void AWidgetCanSetToBeAPentagon()
    {
        var w = new Widget();
        w.SetType(Type.Pentagon);
    }

    [Test]
    public void APentagonWidgetDescribesItselfAsAPentagon()
    {
        var w = new Widget();
        w.SetType(Type.Pentagon);

        Assert.AreEqual("Pentagon", w.Describe());
    }

    [Test]
    public void APentagonWidgetDrawsAsAPentagon()
    {
        VerifyCorrectNumberOfVertices(Type.Pentagon, 5);
    }

    [Test]
    public void AWidgetCanSetToBeAHexagon()
    {
        var w = new Widget();
        w.SetType(Type.Hexagon);
    }

    [Test]
    public void AHexagonWidgetDescribesItselfAsAHexagon()
    {
        var w = new Widget();
        w.SetType(Type.Hexagon);

        Assert.AreEqual("Hexagon", w.Describe());
    }

    [Test]
    public void AHexagonWidgetDrawsAsAHexagon()
    {
        VerifyCorrectNumberOfVertices(Type.Hexagon, 6);
    }

    private static void VerifyCorrectNumberOfVertices(Type type, int vertices)
    {
        var w = new Widget();
        w.SetType(type);

        var c = new Mock<ICanvas>();

        w.Draw(c.Object);

        c.Verify(mock => mock.DrawVertex(It.IsAny<Point>()), Times.Exactly(vertices));
    }
}