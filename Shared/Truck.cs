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
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal SiteId { get; set; }
        public decimal AssetId { get; set; }
        public string RegistrationNumber { get; set; } = string.Empty;
        public DateTime LastPositionTimestamp { get; set; }
        public double Latitude { get; set; }
        public double Longitute { get; set; }
        public string CurrentAddress { get; set; } = string.Empty;
    }
}
