using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(id);

                if (entity == null)
                {
                    throw new InvalidOperationException("Entity Bulunamadı");
                }
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Silme işlemi başarısız", e);
            }

        }

        public async Task<T> GetByID(int id)
        {
            try
            {
                var value = await _context.Set<T>().FindAsync(id);
                return value ?? throw new InvalidOperationException("Entity Bulunamadı");
            }
            catch (Exception e)
            {
                throw new Exception("ID'ye göre getirme işlemi başarısız", e);
            }
        }

        public async Task<List<T>> GetList()
        {

            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception e)
            {

                throw new Exception("Liste getirme işlemi başarısız", e);
            }
        }

        public async Task Insert(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Entity null olamaz");
            }

            try
            {
                await _context.AddAsync(t);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception("Kaydetme işlemi başarısız", e);
            }
        }

        public async Task Update(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Entity null olamaz");
            }

            try
            {
                _context.Update(t);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                throw new Exception("Güncelleme işlemi başarısız", e);
            }
        }
    }
}
