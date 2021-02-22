using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SP_BAL.Interfaces
{
    public interface IBrandManager
    {
        List<Brands> getAllBrands();
        string CreateBrand(Brands brand);
        string UpdateBrand(Brands brand);
        bool IsActive(int BrandId);
        Brands getBrand(int BrandId);
        string DeleteBrand(int BrandId);

    }
}
