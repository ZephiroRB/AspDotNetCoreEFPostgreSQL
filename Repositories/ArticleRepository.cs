using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zRoApplication.Data;
using zRoApplication.Interfaces;
using zRoApplication.Models;

namespace zRoApplication.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private DataContext _context = null;
        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Article>> GetArticles()
        {
            var articles = await _context.Articles.ToListAsync();
            return articles;
        }

    }
}
