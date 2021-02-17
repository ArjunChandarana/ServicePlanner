using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Models
{
   public class SelectedServices
    {
        public int SelectedServiceId { get; set; }
        public int ServiceBookingId { get; set; }
        public int ServiceId { get; set; }

        public virtual ServiceBooking ServiceBooking { get; set; }
        public virtual Services Service { get; set; }
    }
}
