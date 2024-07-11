using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _socialMediaDal.DeleteAsync(id);
        }

        public async Task<List<SocialMedia>> TGetAllAsync()
        {
            return await _socialMediaDal.GetAllAsync();
        }

        public async Task<SocialMedia> TGetByIdAsync(int id)
        {
            return await _socialMediaDal.GetByIdAsync(id);
        }

        public async Task TInsertAsync(SocialMedia entity)
        {
            await _socialMediaDal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(SocialMedia entity)
        {
            await _socialMediaDal.UpdateAsync(entity);
        }
    }
}
