using Foody.BusinessLayer.Abstract;
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
        public async Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address>> TGetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Address> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsert(Address entity)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdate(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
