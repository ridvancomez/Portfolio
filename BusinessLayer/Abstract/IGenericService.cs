using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<List<T>> GetList();
        Task<T> GetById(int id);
    }
}
