using MediatR;
using Resistella.API.IU.Application.DTOs;
using Resistella.Core.Domain;
using Resistella.Core.Domaine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Resistella.API.IU.Application.Queries
{
    public class SelectAllArticleHandler : IRequestHandler<SelectAllArticleQuery, List<ArticleDto>>
    {
        #region Fields
        private readonly IArticleRepository<Article> _repository = null;
        #endregion
        #region Constructor
        public SelectAllArticleHandler(IArticleRepository<Article> repository)
        {
            _repository = repository;
        }
        #endregion
        public Task<List<ArticleDto>> Handle(SelectAllArticleQuery request, CancellationToken cancellationToken)
        {
            var listArticle = this._repository.GetAll(request.CollectionObjectId);
            var result = listArticle.Select
                (item => new ArticleDto
                {
                    Id = item.Id,
                    Title = item.Title,
                    Detail = item.Detail,
                    CollectionName = item.CollectionObject.Name,
                    Price = item.Price
                }).ToList();

            return Task.FromResult(result);
        }
    }
}
