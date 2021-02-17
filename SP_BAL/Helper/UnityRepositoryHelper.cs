using SP_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace SP_BAL.Helper
{
    public class UnityRepositoryHelper:UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IBrand, BrandRepository>();
            Container.RegisterType<IDealer, DealerRepository>();
            Container.RegisterType<IVehicle, VehicleRepository>();
            Container.RegisterType<ICustomer, CustomerRepository>();
            Container.RegisterType<IService, ServiceRepository>();
            Container.RegisterType<IMechanic, MechanicRepository>();
            Container.RegisterType<IModel, ModelRepository>();
            Container.RegisterType<IUsers_Receptionist_Advisior, Users_Receptionist_AdvisiorRepository>();
            Container.RegisterType<ISelectedService, SelectedServiceRepository>();
        }
    }
}
