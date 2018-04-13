using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Ispitna
{
   public class Destination
    {
        public string DestinationName { get; set; }
        public int DestinationDistance { get; set; }
        public int DestinationPrice { get; set; }
        public Destination (string name, int distance, int price)
        {
            DestinationName = name;
            DestinationDistance = distance;
            DestinationPrice = price;
        }
        public override string ToString()
        {
            return string.Format("{0}   {1} km-{2} EUR", DestinationName, DestinationDistance, DestinationPrice);
        }
    }
}
