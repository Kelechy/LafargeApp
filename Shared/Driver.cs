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
        public int PkId { get; set; }
        public long Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long SiteId { get; set; }
        public long DriverId { get; set; }
        public string Name { get; set; } = string.Empty;
        public long EmployeeNumber { get; set; }
    }
}
