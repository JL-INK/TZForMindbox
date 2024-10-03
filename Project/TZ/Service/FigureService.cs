namespace TZ
{
    public class FigureService : IFigureService
    {
        ///<inheritdoc />
        public double FindAreaUnknownFigure(double value1)
        {
            return FindAreaCircle(value1);
        }

        ///<inheritdoc />
        public double FindAreaUnknownFigure(double value1, double value2, double value3)
        {
            return FindAreaTriangle(value1,value2,value3);
        }

        ///<inheritdoc />
        public double FindAreaCircle(double radius)
        {
            Circle circle = new Circle
            {
                Radius = radius
            };

            return circle.Area;
        }

        ///<inheritdoc />
        public double FindAreaTriangle(double side1,double side2, double side3)
        {
            Triangle triangle = new Triangle()
            {
                Side1 = side1,
                Side2 = side2,
                Side3 = side3
            };

            return triangle.Area;
        }

        ///<inheritdoc />
        public bool TriangleIsRectangular(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle()
            {
                Side1 = side1,
                Side2 = side2,
                Side3 = side3
            };

            return triangle.IsRectangular;
        }
    }
}
