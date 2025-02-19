using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public BlogRepository(Context context) : base(context)
        {
        }
    }
}
