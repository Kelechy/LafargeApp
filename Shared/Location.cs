using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LafargeApp.Shared
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AgeOfReadingSeconds { get; set; }
        public decimal AssetId { get; set; }
        public int AltitudeMetres { get; set; }
        public decimal DriverId { get; set; }
        public int Heading { get; set; }
        public double Latitude { get; set; }
        public int IsAvl { get; set; }
        public int OdometerKilometres { get; set; }
        public double Longitute { get; set; }
        public int Hdop { get; set; }
        public decimal PositionId { get; set; }
        public int Pdop { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Source { get; set; }
        public int SpeedKilometresPerHour { get; set; }
        public int SpeedLimit { get; set; }
        public int Vdop { get; set; }
    }
}
