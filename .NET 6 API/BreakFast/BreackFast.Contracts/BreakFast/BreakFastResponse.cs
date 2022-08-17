using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreackFast.Contracts.BreakFast
{
    public class BreakFastResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = null;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public DateTime LastModefiedDate { get; set; } = DateTime.Now;

        public List<string> Savory = new List<string>();

        public List<string> Sweet = new List<string>();
    }
}
