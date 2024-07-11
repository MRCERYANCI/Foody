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
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _reviewDal.DeleteAsync(id);
        }

        public async Task<List<Review>> TGetAllAsync()
        {
            return await _reviewDal.GetAllAsync();
        }

        public async Task<Review> TGetByIdAsync(int id)
        {
            return await _reviewDal.GetByIdAsync(id);
        }

        public async Task TInsertAsync(Review entity)
        {
            await _reviewDal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(Review entity)
        {
            await _reviewDal.UpdateAsync(entity);   
        }
    }
}
