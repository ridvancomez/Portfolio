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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public async Task Add(Testimonial entity)
        {
            await _testimonialDal.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _testimonialDal.Delete(id);
        }

        public async Task<Testimonial> GetById(int id)
        {
            return await _testimonialDal.GetByID(id);
        }

        public async Task<List<Testimonial>> GetList()
        {
            return await _testimonialDal.GetList();
        }

        public async Task Update(Testimonial entity)
        {
            await _testimonialDal.Update(entity);
        }
    }
}
