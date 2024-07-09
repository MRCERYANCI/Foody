using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TInsert(T entity);
        Task TUpdate(T entity);
        Task TDelete(int id);
        Task<List<T>> TGetAll();
        Task<T> TGetById(int id);
    }
}
