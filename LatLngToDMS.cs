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
			Console.WriteLine(LatLngToDMS(40.928043d,29.3090168d));
		}
		
		static string LatLngToDMS(double lat, double lon)
        {
    
            string latDir = (lat >= 0 ? "N" : "S");
            lat = Math.Abs(lat);
            double latMinPart = ((lat - Math.Truncate(lat) / 1) * 60);
            double latSecPart = ((latMinPart - Math.Truncate(latMinPart) / 1) * 60);
    
            string lonDir = (lon >= 0 ? "E" : "W");
            lon = Math.Abs(lon);
            double lonMinPart = ((lon - Math.Truncate(lon) / 1) * 60);
            double lonSecPart = ((lonMinPart - Math.Truncate(lonMinPart) / 1) * 60);
    
            string latStr = Math.Truncate(lat) + " " + Math.Truncate(latMinPart) + " " + Math.Truncate(latSecPart) + " " + latDir;
            string lonStr = Math.Truncate(lon) + " " + Math.Truncate(lonMinPart) + " " + Math.Truncate(lonSecPart) + " " + lonDir;
            Console.WriteLine("Lat To degrees°minute’seconds: " + latStr);
            Console.WriteLine("lon To degrees°minute’seconds: " + lonStr);
            return latStr + " " + lonStr;
        }
	}
}
