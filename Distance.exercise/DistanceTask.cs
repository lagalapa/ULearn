using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            //если отрезок вырожденный, то находим расстояние между двумя точками
            if (ax == bx && ay == by)
                return Math.Sqrt(Math.Pow(x - ax, 2) + Math.Pow(y - ay, 2));
            
            // иначе с помощью скалярного произведения определяем, падает ли перпендикуляр на отрезок
            // если скалярное произведение меньше нуля, значит перпендикуляр не падает на отрезок
            // и значит будем находить кратчайшее из расстояний от точки до концов отрезка
            else if ((x - ax) * (bx - ax) + (y - ay) * (by - ay) < 0 ||
                    (x - bx) * (ax - bx) + (y - by) * (ay - by) < 0)
                return Math.Min(Math.Sqrt(Math.Pow(x - ax, 2) + Math.Pow(y - ay, 2)), 
                       Math.Sqrt(Math.Pow(x - bx, 2) + Math.Pow(y - by, 2)));
            // иначе находим расстояние от точки до прямой
            else
                return Math.Abs((by - ay) * x - (bx - ax) * y + bx * ay - by * ax) /
                       Math.Sqrt(Math.Pow(by - ay, 2) + Math.Pow(bx - ax, 2));

        }
	}
}