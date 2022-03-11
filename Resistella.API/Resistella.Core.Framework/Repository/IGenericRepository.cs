using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Framework.Repository
{
    public interface IGenericRepository<T> :IUnitOfWork where T : class
    {
        IUnitOfWork UnitOfWork { get; }
   
        Task<T> Get(int id);
        Task<T> Add(T obj);
        Task<T> Update(T obj);
        void Delete(int id);
    }
}
