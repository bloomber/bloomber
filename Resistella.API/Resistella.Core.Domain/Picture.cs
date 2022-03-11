using System;

namespace Resistella.Core.Domain
{
    public class Picture
    {
        public int Id { get; set; }
        public string Picture_Path { get; set; }



        public int Id_Article { get; set; }
        public Article Article { get; set; }
    }
}