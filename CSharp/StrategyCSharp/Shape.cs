using Moq;

namespace StrategyCSharp
{
    public class Shape
    {
        private readonly Type _type;

        public Shape(Type type)
        {
            _type = type;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawVertex(new Point(0, 0));
            canvas.DrawVertex(new Point(2, 0));
            if (_type == Type.Triangle)
            {
                canvas.DrawVertex(new Point(1, 2));
            }
            else
            {
                canvas.DrawVertex(new Point(0, 2));
                canvas.DrawVertex(new Point(2, 2));
            }

            if (_type == Type.Pentagon)
            {
                canvas.DrawVertex(new Point(1, 3));
            }
            else if (_type == Type.Hexagon)
            {
                canvas.DrawVertex(new Point(3, 1));
                canvas.DrawVertex(new Point(-1, 1));
            }
        }
    }
}