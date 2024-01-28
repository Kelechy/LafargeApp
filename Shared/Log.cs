using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LafargeApp.Shared
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public string Action { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string ActionBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
    }
}
