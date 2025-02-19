using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task Insert(T t);
        Task Update(T t);
        Task Delete(int id);
        Task<T> GetByID(int id);
        Task<List<T>> GetList();
    }
}
