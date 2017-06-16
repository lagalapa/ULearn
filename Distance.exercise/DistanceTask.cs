using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
             return Math.Abs((by - ay) * x - (bx - ax) * y + bx * ay - by * ax) / Math.Sqrt((by - ay) * (by - ay) + (bx - ax) * (bx - ax));
		}
	}
}