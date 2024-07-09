using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        public async Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> TGetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsert(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
