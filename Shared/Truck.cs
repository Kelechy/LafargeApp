using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LafargeApp.Shared
{
    public class Truck
    {
        [Key]
        public int PkId { get; set; }
        public int Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long SiteId { get; set; }
        public long AssetId { get; set; }
        public string RegistrationNumber { get; set; } = string.Empty;
        public string LastPositionTimestamp { get; set; }
        public double Latitude { get; set; }
        public double Longitute { get; set; }
        public string CurrentAddress { get; set; } = string.Empty;
    }
}
