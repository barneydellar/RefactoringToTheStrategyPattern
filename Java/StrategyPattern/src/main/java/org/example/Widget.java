package org.example;

public class Widget
{
    private Type type = Type.Triangle;

    public String describe()
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

    public void setType(Type type)
    {
        this.type = type;
    }

    public void draw(ICanvas canvas)
    {
        canvas.drawVertex(new Point(0, 1));
        canvas.drawVertex(new Point(2, 0));
        if (type == Type.Triangle)
        {
            canvas.drawVertex(new Point(1, 2));
        }
        else
        {
            canvas.drawVertex(new Point(0, 2));
            canvas.drawVertex(new Point(2, 2));
        }
        switch (type)
        {
            case Pentagon:
                canvas.drawVertex(new Point(1, 3));
                break;
            case Hexagon:
                canvas.drawVertex(new Point(3, 1));
                canvas.drawVertex(new Point(-1, 1));
                break;
        }
    }
}