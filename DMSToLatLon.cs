using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace enosoft.geo.utils
{
	class Program
	{
		static void Main(string[] args)
		{
			double lat = DMSToLatLon(40,55,40);
			Console.WriteLine("lat : " + lat);
		}
		
		static double DMSToLatLon(double degrees, double minutes, double seconds)
        {
            double DecimalDegrees = degrees + (minutes / 60) + (seconds / 3600);
            return DecimalDegrees;
        }
	}
}
