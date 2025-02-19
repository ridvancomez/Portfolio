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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public async Task Add(Contact entity)
        {
            await _contactDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _contactDal.Delete(id);
        }

        public async Task<Contact> GetById(int id)
        {
            return await _contactDal.GetByID(id);
        }

        public async Task<List<Contact>> GetList()
        {
            return await _contactDal.GetList();
        }

        public async Task Update(Contact entity)
        {
            await _contactDal.Update(entity);
        }
    }
}
