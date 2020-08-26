using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zRoApplication.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ArticleDate { get; set; }
    }
}
