using Microsoft.EntityFrameworkCore;
using Resistella.Core.Domain;
using Resistella.Core.Domaine.Repository;
using Resistella.Core.Framework;
using Resistella.Core.Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Infrastructures.Data.Repository
{
    public class ArticleRepository : IArticleRepository<Article>
    {
        #region Fields
        private readonly ResistellaContext _context;
        #endregion

        #region constructor
        public ArticleRepository(ResistellaContext context)
        {
            _context = context;
        }
        #endregion
        #region public methods
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Task<Article> Add(Article obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Article> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Article> Update(Article obj)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }


         ICollection<Article> IArticleRepository<Article>.GetAll(int collectionObjectId)
        {
            var query = this._context.Articles.Include(item => item.CollectionObject).AsQueryable();

            if (collectionObjectId > 0)
                query = query.Where(item => item.CollectionObject.Id == collectionObjectId);

            return  query.ToList();
        }


        #endregion
    }
}
