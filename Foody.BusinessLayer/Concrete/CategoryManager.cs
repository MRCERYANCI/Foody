using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public async Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> TGetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
