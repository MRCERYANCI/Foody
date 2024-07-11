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
        private readonly IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public async Task TDeleteAsync(int id)
        {
           await _productService.TDeleteAsync(id);
        }

        public async Task<List<Product>> TGetAllAsync()
        {
            return await _productService.TGetAllAsync();
        }

        public async Task<Product> TGetByIdAsync(int id)
        {
            return await _productService.TGetByIdAsync(id);
        }

        public async Task TInsertAsync(Product entity)
        {
            await _productService.TInsertAsync(entity);
        }

        public async Task TUpdateAsync(Product entity)
        {
            await _productService.TUpdateAsync(entity);
        }
    }
}
