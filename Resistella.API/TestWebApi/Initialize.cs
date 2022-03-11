using Resistella.API.IU.Application.DTOs;
using Resistella.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi
{
    public class Initialize
    {
        /// <summary>
        /// Initialize Domaine Object (Data TEST)
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="collectionObjects"></param>
        /// <param name="articles"></param>
        public void InitializeDomaine(out List<Tag> tags, out List<CollectionObject> collectionObjects, out List<Article> articles)
        {
            tags = new List<Tag>()
            {
                new Tag(){ Name="Blue"},
                new Tag(){ Name="Cercle"},
                new Tag(){ Name="Lune"},
                new Tag(){ Name="Black"}
            };

            collectionObjects = new List<CollectionObject>()
            {
                new CollectionObject()
                {
                    Name = "Poudre de lune",
                    Availability_Date = DateTime.Now.AddDays(10),
                    Available = false,
                    Expiration_Date = DateTime.Now.AddDays(20)
                },
                new CollectionObject()
                {
                    Name = "Poudre Rouge",
                    Availability_Date = DateTime.Now,
                    Available = true,
                    Expiration_Date = DateTime.Now.AddDays(20)
                }
            };

            int tagSize = tags.Count();

            var randTage = new Random();
            articles = new List<Article>()
            {
                 new Article()
                 {
                     Title="Pendentif de lune",
                     Tags=tags.OrderBy(x =>randTage.Next(0,tagSize)).Take(3).ToList(),
                     Price=2.5,
                     Detail="Magnifique bijoux en résine, celle-ci est idéale pour vos soirée festive",
                     CollectionObject=collectionObjects.First()
                 },
                 new Article()
                 {
                     Title="boucle d'oreil de lune",
                     Tags=tags.OrderBy(x =>randTage.Next(0,tagSize)).Take(3).ToList(),
                     Price=10.5,
                     Detail="Magnifique bijoux en résine, celle-ci est idéale pour vos soirée festive",
                     CollectionObject=collectionObjects.First()
                 },

                 new Article()
                 {
                     Title="Pendentif de rouge",
                     Tags=tags.OrderBy(x =>randTage.Next(0,tagSize)).Take(3).ToList(),
                     Price=2.5,
                     Detail="Magnifique bijoux en résine, celle-ci est idéale pour vos soirée festive",
                     CollectionObject=collectionObjects[1]
                 },
                 new Article()
                 {
                     Title="boucle d'oreil de rouge",
                     Tags=tags.OrderBy(x =>randTage.Next(0,tagSize)).Take(3).ToList(),
                     Price=10.5,
                     Detail="Magnifique bijoux en résine, celle-ci est idéale pour vos soirée festive",
                     CollectionObject=collectionObjects[1]
                 }
            };
        }

        internal List<ArticleDto> GetArticleDto(List<Article> articles)
        {
            return articles.Select(item =>
            new ArticleDto()
            {
                Id = item.Id,
                Title = item.Title,
                Detail = item.Detail,
                CollectionName = item.CollectionObject.Name,
                Price = item.Price
            }).ToList();
        }
    }
}
