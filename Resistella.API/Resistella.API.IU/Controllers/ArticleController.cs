using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Resistella.API.IU.Application.Queries;
using Resistella.Core.Domain;
using Resistella.Core.Domaine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resistella.API.IU.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ArticleController : Controller
    {
        #region Fields
        private readonly IArticleRepository<Article> _repository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        private readonly IMediator _mediator = null;

        #endregion

        #region Constructor
        public ArticleController(IMediator mediator, IArticleRepository<Article> repository, IWebHostEnvironment webHostEnvironment)
        {

            this._webHostEnvironment = webHostEnvironment;
            this._mediator = mediator;
            _repository = _repository;
        }
        #endregion

        #region public methods
        [HttpGet]
        public async Task<IActionResult> GetAll(int collectionObjectId = 0)
        {
            var model = await this._mediator.Send(new SelectAllArticleQuery() { CollectionObjectId = collectionObjectId });

            return this.Ok(model);
        }



        #endregion
    }
}
