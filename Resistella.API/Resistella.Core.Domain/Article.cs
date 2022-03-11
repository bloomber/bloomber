using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Domain
{
    public class Article
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }

        public double Price { get; set; }

        public DateTime Publish_Date { get; set; }
        public bool Available { get; set; }



        public int Id_Collection { get; set; }
        public CollectionObject CollectionObject { get; set; }

        public List<Tag> Tags { get; set; }
        public List<Picture> Pictures { get; set; }



        #endregion
    }
}
