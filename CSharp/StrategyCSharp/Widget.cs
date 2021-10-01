using Moq;

namespace StrategyCSharp
{
    public class Widget
    {
        private Type _type = Type.Triangle;

        public string Describe()
        {
            if (_type == Type.Triangle)
            {
                return "Triangle";
            }
            else if (_type == Type.Square)
            {
                return "Square";
            }
            else if (_type == Type.Pentagon)
            {
                return "Pentagon";
            }
            else if (_type == Type.Hexagon)
            {
                return "Hexagon";
            }
            return "";
        }

        public void SetType(Type type)
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
            switch (_type)
            {
                case Type.Pentagon:
                    canvas.DrawVertex(new Point(1, 3));
                    break;
                case Type.Hexagon:
                    canvas.DrawVertex(new Point(3, 1));
                    canvas.DrawVertex(new Point(-1, 1));
                    break;
            }
        }
    }
}