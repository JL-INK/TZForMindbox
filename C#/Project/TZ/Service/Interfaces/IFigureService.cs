namespace TZ
{
    public interface IFigureService
    {
        /// <summary>
        /// Найти площадь неизвестной фигуры
        /// </summary>
        /// <param name="value1">Значение 1</param>
        /// <returns>Площадь</returns>
        double FindAreaUnknownFigure(double value1);

        /// <summary>
        /// Найти площадь неизвестной фигуры
        /// </summary>
        /// <param name="value1">Значение 1</param>
        /// <param name="value2">Значение 2</param>
        /// <param name="value3">Значение 3</param>
        /// <returns>Площадь</returns>
        double FindAreaUnknownFigure(double value1, double value2, double value3);

        /// <summary>
        /// Найти площадь круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Площадь</returns>
        double FindAreaCircle(double radius);

        /// <summary>
        /// Найти площадь треугольника
        /// </summary>
        /// <param name="side1">Сторона 1</param>
        /// <param name="side2">Сторона 2</param>
        /// <param name="side3">Сторона 3</param>
        /// <returns>Площадь</returns>
        double FindAreaTriangle(double side1, double side2, double side3);

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="side1">Сторона 1</param>
        /// <param name="side2">Сторона 2</param>
        /// <param name="side3">Сторона 3</param>
        /// <returns>True/False</returns>
        bool TriangleIsRectangular(double side1, double side2, double side3);
    }
}
