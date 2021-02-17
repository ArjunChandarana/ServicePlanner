using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Models
{
  public  class Services
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int Amount { get; set; }
    }
}
