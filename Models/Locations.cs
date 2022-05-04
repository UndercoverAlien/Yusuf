namespace Novacyt.Models
{
    public class Locations
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string Title { get; set; }

        public Locations(string Title, double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.Title = Title;
        }
    }
}