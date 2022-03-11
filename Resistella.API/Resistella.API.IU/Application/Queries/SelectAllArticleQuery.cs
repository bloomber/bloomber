using MediatR;
using Resistella.API.IU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resistella.API.IU.Application.Queries
{
    public class SelectAllArticleQuery : IRequest<List<ArticleDto>>
    {
        #region Fields
        public int CollectionObjectId { get; set; }
        #endregion
    }
}
