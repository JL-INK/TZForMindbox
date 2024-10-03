using System;

namespace TZ
{
    public class Circle : Figure
    {
        /// <summary>
        /// Ид типа фигуры
        /// </summary>
        protected int TypeId => 1;

        /// <summary>
        /// Наименование фигуры
        /// </summary>
        protected string Name => "Circle";

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        /// <returns></returns>
        public double Area => 3.14 * Math.Pow(Radius, 2);
    }
}
