using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resistella.Core.Domain;
using Resistella.Core.Framework.Repository;

namespace Resistella.Core.Domaine.Repository
{
    public interface IArticleRepository<T> : IGenericRepository<T> where T : class
    {
        ICollection<T> GetAll(int collectionObjectId);
    }
}
