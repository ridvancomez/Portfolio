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
    public class ApplicationUserManager : IApplicationUserService
    {
        IApplicationUserDal _applicationUsertDal;

        public ApplicationUserManager(IApplicationUserDal applicationUsertDal)
        {
            _applicationUsertDal = applicationUsertDal;
        }

        public async Task Add(ApplicationUser entity)
        {
            await _applicationUsertDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _applicationUsertDal.Delete(id);
        }

        public async Task<ApplicationUser> GetById(int id)
        {
            return await _applicationUsertDal.GetByID(id);
        }

        public async Task<List<ApplicationUser>> GetList()
        {
            return await _applicationUsertDal.GetList();
        }

        public async Task Update(ApplicationUser entity)
        {
            await _applicationUsertDal.Update(entity);
        }
    }
}

