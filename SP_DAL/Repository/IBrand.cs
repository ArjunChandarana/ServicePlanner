using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_DAL.Database;
using SP_Models;


namespace SP_DAL.Repository
{
   public  interface IBrand
    {
        string CreateBrand(Brands brand);
        string UpdateBrand(Brands brand);
        List<Brands> getAllBrands();
        bool IsActive(int BrandId);
        Brands getBrand(int BrandId);
        string DeleteBrand(int BrandId);
    }
}
