using System.ComponentModel.DataAnnotations;

namespace LafargeApp.Shared
{
    public class Location
    {
        [Key]
        public int PkId { get; set; }
        public int Id { get; set; }        
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long AgeOfReadingSeconds { get; set; }
        public long AssetId { get; set; }
        public long AltitudeMetres { get; set; }
        public long DriverId { get; set; }
        public long Heading { get; set; }
        public double Latitude { get; set; }
        public long IsAvl { get; set; }
        public long OdometerKilometres { get; set; }
        public double Longitude { get; set; }
        public long Hdop { get; set; }
        public long PositionId { get; set; }
        public long Pdop { get; set; }
        public string TimeStamp { get; set; }
        public long Source { get; set; }
        public long SpeedKilometresPerHour { get; set; }
        public long SpeedLimit { get; set; }
        public long Vdop { get; set; }
    }
}
