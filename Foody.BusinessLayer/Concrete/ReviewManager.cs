using Foody.BusinessLayer.Abstract;
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
        public async Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Review>> TGetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Review> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsert(Review entity)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdate(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
