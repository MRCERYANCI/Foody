using Foody.BusinessLayer.Abstract;
using Foody.BusinessLayer.Concrete;
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.EntityFramework;

namespace Foody.PresentationLayer.Containers
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            services.AddDbContext<FoodyContext>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal,EfCategoryDal>();
        }
    }
}
