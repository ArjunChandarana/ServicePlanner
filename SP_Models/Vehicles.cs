using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Models
{
   public class Vehicles
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string NumberPlate { get; set; }
        public string ChasisNumber { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public System.DateTime LastServiceDate { get; set; }
        public int CustomerId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string FuelType { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Model Model { get; set; }
    }
}
