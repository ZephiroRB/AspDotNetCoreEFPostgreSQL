using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zRoApplication.Models;

namespace zRoApplication.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticles();
    }
}
