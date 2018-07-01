using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore21.Models
{
    public abstract class Asset
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TS { get; set; }
        public char Act { get; set; }
    }
}
