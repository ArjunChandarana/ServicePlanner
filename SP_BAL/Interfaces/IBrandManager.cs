﻿using SP_DAL.Database;
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
        string CreateBrand(Brand brand);
        string UpdateBrand(Brand brand);
        bool IsActive(int BrandId);
    }
}
