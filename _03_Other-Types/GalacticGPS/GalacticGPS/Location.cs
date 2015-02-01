using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Pln { get; set; }

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Pln = planet;
        }

        public override string ToString()
        {
            return this.Latitude + ", " + this.Longitude + " - " + this.Pln;
        }
    }

    public enum Planet
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }
}
