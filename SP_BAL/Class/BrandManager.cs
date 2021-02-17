using SP_BAL.Interfaces;
using SP_DAL.Database;
using SP_DAL.Repository;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Class
{
    public class BrandManager : IBrandManager
    {
        private readonly IBrand _IBrand;

      public  BrandManager(IBrand brand)
        {
            _IBrand = brand;
        }

      
        public List<Brands> getAllBrands()
        {
            return _IBrand.getAllBrands();
        }

        public string CreateBrand(Brand brand)
        {
            return _IBrand.CreateBrand(brand);
        }

        public string UpdateBrand(Brand brand)
        {
            return _IBrand.UpdateBrand(brand);
        }

        public bool IsActive(int BrandId)
        {
            return _IBrand.IsActive(BrandId);
        }
    }
}
