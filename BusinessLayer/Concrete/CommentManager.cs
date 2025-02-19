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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public async Task Add(Comment entity)
        {
            await _commentDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _commentDal.Delete(id);
        }

        public async Task<Comment> GetById(int id)
        {
            return await _commentDal.GetByID(id);
        }

        public async Task<List<Comment>> GetList()
        {
            return await _commentDal.GetList();
        }

        public async Task Update(Comment entity)
        {
            await _commentDal.Update(entity);
        }
    }
}
