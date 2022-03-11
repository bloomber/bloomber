using Resistella.Core.Domain;
using Resistella.Core.Framework;
using Resistella.Core.Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Infrastructures.Data.Repository
{
    class CollectionObjectRepository : ICollectionObjectRepository<CollectionObject>
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Task<CollectionObject> Add(CollectionObject obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CollectionObject> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CollectionObject>> GetAll()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<CollectionObject> Update(CollectionObject obj)
        {
            throw new NotImplementedException();
        }


    }
}
