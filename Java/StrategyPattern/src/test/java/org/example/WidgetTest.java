package org.example;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.*;

public class WidgetTest
{
    @Test
    public void aWidgetCanBeCreated()
    {
        var w = new Widget();
    }

    @Test
    public void aWidgetCanDescribeItself()
    {
        var w = new Widget();
        w.describe();
    }

    @Test
    public void aWidgetStartsAsATriangle()
    {
        var w = new Widget();
        assertEquals("Triangle", w.describe());
    }

    @Test
    public void aWidgetSTypeCanBeChangedAtRunTime()
    {
        var w = new Widget();
        assertEquals("Triangle", w.describe());
        w.setType(Type.Square);

        assertEquals("Square", w.describe());
    }

    @Test
    public void aWidgetCanSetToBeATriangle()
    {
        var w = new Widget();
        w.setType(Type.Triangle);
    }

    @Test
    public void aTriangularWidgetDescribesItselfAsATriangle()
    {
        var w = new Widget();
        w.setType(Type.Triangle);

        assertEquals("Triangle", w.describe());
    }

    @Test
    public void aTriangularWidgetDrawsAsATriangle()
    {
        VerifyCorrectNumberOfVertices(Type.Triangle, 3);
    }

    @Test
    public void aWidgetCanSetToBeASquare()
    {
        var w = new Widget();
        w.setType(Type.Square);
    }

    @Test
    public void aSquareWidgetDescribesItselfAsASquare()
    {
        var w = new Widget();
        w.setType(Type.Square);

        assertEquals("Square", w.describe());
    }

    @Test
    public void aSquareWidgetDrawsAsASquare()
    {
        VerifyCorrectNumberOfVertices(Type.Square, 4);
    }

    @Test
    public void aWidgetCanSetToBeAPentagon()
    {
        var w = new Widget();
        w.setType(Type.Pentagon);
    }

    @Test
    public void aPentagonWidgetDescribesItselfAsAPentagon()
    {
        var w = new Widget();
        w.setType(Type.Pentagon);

        assertEquals("Pentagon", w.describe());
    }

    @Test
    public void aPentagonWidgetDrawsAsAPentagon()
    {
        VerifyCorrectNumberOfVertices(Type.Pentagon, 5);
    }

    @Test
    public void aWidgetCanSetToBeAHexagon()
    {
        var w = new Widget();
        w.setType(Type.Hexagon);
    }

    @Test
    public void aHexagonWidgetDescribesItselfAsAHexagon()
    {
        var w = new Widget();
        w.setType(Type.Hexagon);

        assertEquals("Hexagon", w.describe());
    }

    @Test
    public void aHexagonWidgetDrawsAsAHexagon()
    {
        VerifyCorrectNumberOfVertices(Type.Hexagon, 6);
    }

    private static void VerifyCorrectNumberOfVertices(Type type, int vertices)
    {
        var w = new Widget();
        w.setType(type);

        var c = mock(ICanvas.class);

        w.draw(c);

        verify(c, times(vertices)).drawVertex(any(Point.class));
    }
}