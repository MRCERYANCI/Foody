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
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _addressDal.DeleteAsync(id);
        }

        public async Task<List<Address>> TGetAllAsync()
        {
            return await _addressDal.GetAllAsync();
        }

        public async Task<Address> TGetByIdAsync(int id)
        {
           return await _addressDal.GetByIdAsync(id);
        }

        public async Task TInsertAsync(Address entity)
        {
            await _addressDal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(Address entity)
        {
            await _addressDal.UpdateAsync(entity);
        }
    }
}
