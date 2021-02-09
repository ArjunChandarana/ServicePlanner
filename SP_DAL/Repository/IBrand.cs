using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_Models;


namespace SP_DAL.Repository
{
   public  interface IBrand
    {
        List<Brands> getAllBrands();
    }
}
