package org.example;

public class Widget
{
    private Type type = Type.Triangle;

    public String Describe()
    {
        if (type == Type.Triangle)
        {
            return "Triangle";
        }
        else if (type == Type.Square)
        {
            return "Square";
        }
        else if (type == Type.Pentagon)
        {
            return "Pentagon";
        }
        else if (type == Type.Hexagon)
        {
            return "Hexagon";
        }
        return "";
    }

    public void SetType(Type type)
    {
        this.type = type;
    }

    public void Draw(ICanvas canvas)
    {
        canvas.DrawVertex(new Point(0, 1));
        canvas.DrawVertex(new Point(2, 0));
        if (type == Type.Triangle)
        {
            canvas.DrawVertex(new Point(1, 2));
        }
        else
        {
            canvas.DrawVertex(new Point(0, 2));
            canvas.DrawVertex(new Point(2, 2));
        }
        switch (type)
        {
            case Pentagon:
                canvas.DrawVertex(new Point(1, 3));
                break;
            case Hexagon:
                canvas.DrawVertex(new Point(3, 1));
                canvas.DrawVertex(new Point(-1, 1));
                break;
        }
    }
}