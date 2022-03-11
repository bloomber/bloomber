using System;
using System.Collections.Generic;

namespace Resistella.Core.Domain
{
    public class CollectionObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Expiration_Date { get; set; }
        public DateTime Availability_Date { get; set; }
        public bool Available { get; set; }
        
        public List<Article> Articles { get; set; }
    }
}