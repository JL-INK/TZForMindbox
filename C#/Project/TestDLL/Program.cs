using System;
using TZ;

namespace TestDLL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IFigureService _figureService = new FigureService();

            Console.WriteLine(_figureService.TriangleIsRectangular(6,8,10));
            Console.ReadKey();
        }
    }
}
