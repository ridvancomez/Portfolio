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
    public class SkillManager : ISkillService
    {
        ISkillDal _SkillDal;

        public SkillManager(ISkillDal SkillDal)
        {
            _SkillDal = SkillDal;
        }

        public async Task Add(Skill entity)
        {
            await _SkillDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _SkillDal.Delete(id);
        }

        public async Task<Skill> GetById(int id)
        {
            return await _SkillDal.GetByID(id);
        }

        public async Task<List<Skill>> GetList()
        {
            return await _SkillDal.GetList();
        }

        public async Task Update(Skill entity)
        {
            await _SkillDal.Update(entity);
        }
    }
}
