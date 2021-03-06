using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        IResult Add(Blog blog);
        IResult Delete(Blog blog);
        IResult Update(Blog blog);
        IDataResult<List<Blog>> GetAll();
        IDataResult<Blog> GetById(int blogId);
        IDataResult<List<Comment>> GetBlogComments(int blogId); 
    }
}
