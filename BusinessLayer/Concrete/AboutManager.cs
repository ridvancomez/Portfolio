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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public async Task Add(About entity)
        {
            await _aboutDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _aboutDal.Delete(id);
        }

        public async Task<About> GetById(int id)
        {
            return await _aboutDal.GetByID(id);
        }

        public async Task<List<About>> GetList()
        {
            return await _aboutDal.GetList();
        }

        public async Task Update(About entity)
        {
            await _aboutDal.Update(entity);
        }
    }
}
