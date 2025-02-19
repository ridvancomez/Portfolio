using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public async Task Add(Feature entity)
        {
            await _featureDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _featureDal.Delete(id);
        }

        public async Task<Feature> GetById(int id)
        {
            return await _featureDal.GetByID(id);
        }

        public async Task<List<Feature>> GetList()
        {
            return await _featureDal.GetList();
        }

        public async Task Update(Feature entity)
        {
            await _featureDal.Update(entity);
        }
    }
}
