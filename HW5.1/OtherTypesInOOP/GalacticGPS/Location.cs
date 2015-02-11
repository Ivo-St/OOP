namespace GalacticGPS
{
    using System.Text;
    public struct Location
    {
        public Location(double latitude, double longitude, Planet planet)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Latitude);
            result.Append(", ");
            result.Append(this.Longitude);
            result.Append(" - ");
            result.Append(this.Planet);
            return result.ToString();
        }
    }
}
