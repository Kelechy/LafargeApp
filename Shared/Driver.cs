using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LafargeApp.Shared
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal SiteId { get; set; }
        public decimal DriverId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int EmployeeNumber { get; set; }
    }
}
