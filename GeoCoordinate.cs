using System;
using System.Collections;
using System.Collections.Generic;

public static class Module1
{
	public static void Main()
	{
		
		List<GeoCoordinate> MyRoute = new List<GeoCoordinate>();
		MyRoute.Add(new GeoCoordinate(10, 5));
		MyRoute.Add(new GeoCoordinate(15, 7));

		
		Console.WriteLine(GeoCoordinate.CalculateRouteDistance(MyRoute.ToArray()));
	}
}



public struct GeoCoordinate
{
	private readonly double m_latitude;
	private readonly double m_longitude;

	public double Latitude {
		get { return m_latitude; }
	}
	public double Longitude {
		get { return m_longitude; }
	}

	public GeoCoordinate(double latitude, double longitude)
	{
		this.m_latitude = latitude;
		this.m_longitude = longitude;
	}

	public override string ToString()
	{
		return string.Format("{0},{1}", Latitude, Longitude);
	}

	// Calculate distance based on the Pythagorean theorem
	public double CalculateDistanceFrom(GeoCoordinate OtherCoordinate)
	{
		double Long = Math.Abs(this.Longitude - OtherCoordinate.Longitude);
		double Lat = Math.Abs(this.Latitude - OtherCoordinate.Latitude);
		return Math.Sqrt(Math.Pow(Long, 2) + Math.Pow(Lat, 2));
	}


	// Route distance based on CalculateDistanceFrom method	
	public static double CalculateRouteDistance(GeoCoordinate[] Route)
	{
		double Distance = 0;
		for (int i = 0; i <= Route.Length- 2; i++) {
			Distance = Distance + Route[i].CalculateDistanceFrom(Route[i + 1]);
		}
		return Distance;
	}

}

