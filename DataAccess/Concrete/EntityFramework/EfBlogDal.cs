using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, SqliteContext>, IBlogDal
    {
        public List<Comment> GetBlogComments(int blogId)
        {
            using(SqliteContext context=new SqliteContext())
            {
                var result = from c in context.Comments
                             join b in context.Blogs
                             on c.BlogId equals b.Id select c;

                return result.ToList();
            }
        }
    }
}
