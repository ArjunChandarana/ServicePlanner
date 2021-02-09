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
        }
    }
}
