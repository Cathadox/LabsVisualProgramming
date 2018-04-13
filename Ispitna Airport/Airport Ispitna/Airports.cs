using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Ispitna
{
    public class Airport
    {
        public string AirportCity { get; set; }
        public string AirportName { get; set; }
        public string AirportShortName { get; set; }
        public List<Destination> destinations { get; set; }
        public Airport (string city, string name, string shortname)
        {
            AirportCity = city;
            AirportName = name;
            AirportShortName = shortname;
            destinations = new List<Destination>();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", AirportShortName, AirportName, AirportCity);
        }
        public void AddDestination(Destination destination)
        {
            Destination ds = destination;
            destinations.Add(ds);
        }
        public Destination MostExpensiveDestination()
        {
            int mostexpensive = 0;
            foreach (Destination destination in destinations)
            {
                if (destination.DestinationPrice > mostexpensive)
                    mostexpensive = destination.DestinationPrice;
            }
            foreach (Destination destination in destinations)
            {
                if (mostexpensive == destination.DestinationPrice)
                    return destination;
            }
            throw new ExceptionNoDestinationFound();

        }
    }
}
