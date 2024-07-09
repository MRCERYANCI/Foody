using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        public async Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Feature>> TGetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Feature> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsert(Feature entity)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
