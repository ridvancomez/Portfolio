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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public async Task Add(Blog entity)
        {
            await _blogDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _blogDal.Delete(id);
        }

        public async Task<Blog> GetById(int id)
        {
            return await _blogDal.GetByID(id);
        }

        public async Task<List<Blog>> GetList()
        {
            return await _blogDal.GetList();
        }

        public async Task Update(Blog entity)
        {
            await _blogDal.Update(entity);
        }
    }
}
