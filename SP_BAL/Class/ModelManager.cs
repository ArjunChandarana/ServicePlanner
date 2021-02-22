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
    public class ModelManager : IModelManager
    {
        private readonly IModel _IModel;

        public ModelManager(IModel model)
        {
            _IModel = model;
        }

        public string AddModel(Models model)
        {
            return _IModel.AddModel(model);
        }

        public List<Models> getAllModels()
        {
            return _IModel.getAllModels();
        }

        public bool IsActive(int ModelId)
        {
            return _IModel.IsActive(ModelId);
        }

        public string UpdateModel(Models model)
        {
            return _IModel.UpdateModel(model);
        }

        public Models getModel(int ModelId)
        {
            return _IModel.getModel(ModelId);
        }

        public string DeleteModel(int ModelId)
        {
            return _IModel.DeleteModel(ModelId);
        }
    }
}
