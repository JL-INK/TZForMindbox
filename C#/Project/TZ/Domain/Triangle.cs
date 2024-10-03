using System;
using System.Collections.Generic;

namespace TZ
{
    class Triangle : Figure
    {
        /// <summary>
        /// Ид типа фигуры
        /// </summary>
        protected int TypeId => 2;

        /// <summary>
        /// Наименование фигуры
        /// </summary>
        protected string Name => "Triangle";

        /// <summary>
        /// Длина стороны 1
        /// </summary>
        public double Side1 { get; set; }

        /// <summary>
        /// Длина стороны 2
        /// </summary>
        public double Side2 { get; set; }

        /// <summary>
        /// Длина стороны 3
        /// </summary>
        public double Side3 { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        /// <returns></returns>
        public double Area
        {
            get
            {
                double perimetr = (Side1 + Side2 + Side3) / 2;

                return Math.Sqrt(perimetr * (perimetr - Side1) * (perimetr - Side2) * (perimetr - Side3));
            }
        }

        /// <summary>
        /// Является прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                double mul1 = Side1 * Side1;
                double mul2 = Side2 * Side2;
                double mul3 = Side3 * Side3;

                var mulList = new List<double> { mul1, mul2, mul3 };
                mulList.Sort();

                return mulList[0] + mulList[1] == mulList[2];
            }
        }
    }
}
