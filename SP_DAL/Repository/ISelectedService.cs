using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
    public interface ISelectedService
    {
        string UpdateSelectedService(SelectedService sservice);
        List<SelectedServices> getAllSServices();
    }
}
