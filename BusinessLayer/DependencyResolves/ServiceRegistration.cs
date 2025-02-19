using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolves
{
    public static class ServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, AboutRepository>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IApplicationUserService, ApplicationUserManager>();
            services.AddScoped<IApplicationUserDal, ApplicationUserRepository>();

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, BlogRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, CommentRepository>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, ContactRepository>();

            services.AddScoped<IContactMessageService, ContactMessageManager>();
            services.AddScoped<IContactMessageDal, ContactMessageRepository>();

            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceDal, ExperienceRepository>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, FeatureRepository>();

            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISkillDal, SkillRepository>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, SocialMediaRepository>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, TestimonialRepository>();

            services.AddDbContext<Context>(options =>
            {
                string connectionString = "Server=DESKTOP-1ETBG6U\\SQLEXPRESS;Database=CorePortfolio;Integrated Security=True;TrustServerCertificate=True;";
            });
        }
    }
}
