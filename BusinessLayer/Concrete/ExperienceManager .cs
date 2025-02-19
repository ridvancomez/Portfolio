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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public async Task Add(Experience entity)
        {
            await _experienceDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _experienceDal.Delete(id);
        }

        public async Task<Experience> GetById(int id)
        {
            return await _experienceDal.GetByID(id);
        }

        public async Task<List<Experience>> GetList()
        {
            return await _experienceDal.GetList();
        }

        public async Task Update(Experience entity)
        {
            await _experienceDal.Update(entity);
        }
    }
}
