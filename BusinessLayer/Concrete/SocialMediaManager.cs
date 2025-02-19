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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _scialMediaDal;

        public SocialMediaManager(ISocialMediaDal scialMediaDal)
        {
            _scialMediaDal = scialMediaDal;
        }

        public async Task Add(SocialMedia entity)
        {
            await _scialMediaDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _scialMediaDal.Delete(id);
        }

        public async Task<SocialMedia> GetById(int id)
        {
            return await _scialMediaDal.GetByID(id);
        }

        public async Task<List<SocialMedia>> GetList()
        {
            return await _scialMediaDal.GetList();
        }

        public async Task Update(SocialMedia entity)
        {
            await _scialMediaDal.Update(entity);
        }
    }
}
