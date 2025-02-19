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
    public class ContactMessageManager : IContactMessageService
    {
        IContactMessageDal _contactMessageDal;

        public ContactMessageManager(IContactMessageDal contactMessageDal)
        {
            _contactMessageDal = contactMessageDal;
        }

        public async Task Add(ContactMessage entity)
        {
            await _contactMessageDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _contactMessageDal.Delete(id);
        }

        public async Task<ContactMessage> GetById(int id)
        {
            return await _contactMessageDal.GetByID(id);
        }

        public async Task<List<ContactMessage>> GetList()
        {
            return await _contactMessageDal.GetList();
        }

        public async Task Update(ContactMessage entity)
        {
            await _contactMessageDal.Update(entity);
        }
    }
}
