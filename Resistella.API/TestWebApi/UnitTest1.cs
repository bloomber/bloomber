using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Resistella.API.IU.Application.DTOs;
using Resistella.API.IU.Application.Queries;
using Resistella.API.IU.Controllers;
using Resistella.Core.Domain;
using Resistella.Core.Domaine.Repository;
using Resistella.Core.Infrastructures.Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace TestWebApi
{
    public class UnitTest1
    {
        #region public Methods
        [Fact]
        public void Should_Test_DomainCreation()
        {
            //ARRANGE 
            List<CollectionObject> collectionObjects;
            List<Article> articles;
            List<Tag> tags;

            var initializer = new Initialize();
            initializer.InitializeDomaine(out tags, out collectionObjects, out articles);
            //ACT
            Assert.Contains(collectionObjects, a => a == articles[0].CollectionObject);
            //ASSERT
        }

        [Fact]
        public void Should_Return_List_of_article()
        {
            //ARRANGE 
            List<CollectionObject> collectionObjects;
            List<Article> articles;
            List<Tag> tags;

            var initializer = new Initialize();
            initializer.InitializeDomaine(out tags, out collectionObjects, out articles);
            List<ArticleDto> articleDtos = initializer.GetArticleDto(articles);
            var repositoryMockArticle = new Mock<IArticleRepository<Article>>();

            repositoryMockArticle.Setup(item => item.GetAll(It.IsAny<int>())).Returns(articles);

            var webHostEnvironment = new Mock<IWebHostEnvironment>().Object;

            var mediator = new Mock<IMediator>();

            var handler = new SelectAllArticleHandler(repositoryMockArticle.Object);
            var query = new SelectAllArticleQuery();

            mediator.Setup(m => m.Send<List<ArticleDto>>(query, It.IsAny<CancellationToken>()))
                .Callback<object,CancellationToken>((notification, cToken) =>
      handler.Handle((SelectAllArticleQuery)notification, cToken));
             



            //ACT

            var articleController = new ArticleController(mediator.Object,repositoryMockArticle.Object, webHostEnvironment);
            var articleResult = articleController.GetAll();

            //ASSERT

            Assert.NotNull(articleResult.Result);
            Assert.IsType<OkObjectResult>(articleResult.Result);

            var allArticles = ((articleResult.Result as OkObjectResult).Value) as List<ArticleDto>;
            Assert.NotNull(allArticles);
            Assert.True(allArticles.Count > 0);
        }
        #endregion
    }
}
