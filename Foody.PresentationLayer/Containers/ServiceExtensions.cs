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

            //services.AddScoped<IAboutService, AboutManager>();
            //services.AddScoped<IAboutDal, EfAboutDal>();

            //services.AddScoped<IAddressService, AddressManager>();
            //services.AddScoped<IAddressDal, EfAddressDal>();

            //services.AddScoped<IFeatureService, FeatureManager>();
            //services.AddScoped<IFeatureDal, EfFeatureDal>();

            //services.AddScoped<IProductService, ProductManager>();
            //services.AddScoped<IProductDal, EfProductDal>();

            //services.AddScoped<IReviewService, ReviewManager>();
            //services.AddScoped<IReviewDal, EfReviewDal>();

            //services.AddScoped<ISliderService, SliderManager>();
            //services.AddScoped<ISliderDal, EfSliderDal>();

            //services.AddScoped<ISocialMediaService, SocialMediaManager>();
            //services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
        }
    }
}
