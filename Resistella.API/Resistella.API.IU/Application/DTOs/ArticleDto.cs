using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resistella.API.IU.Application.DTOs
{
    public class ArticleDto
    {

        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Detail { get; set; }
        public string CollectionName { get; set; }
        #endregion
    }
}
