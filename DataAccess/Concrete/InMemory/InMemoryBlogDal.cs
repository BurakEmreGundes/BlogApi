using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBlogDal : InMemoryEntityRepositoryBase<Blog>, IBlogDal
    {

        public InMemoryBlogDal(List<Blog> items):base(items)
        {
          
        }

        public List<Comment> GetBlogComments(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}
