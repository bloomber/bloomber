using System.Collections.Generic;

namespace Resistella.Core.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<Article> Articles { get; set; }
    }
}