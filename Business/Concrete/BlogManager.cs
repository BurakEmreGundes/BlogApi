using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
            
        public IResult Add(Blog blog)
        {
            _blogDal.Add(blog);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Blog blog)
        {
            _blogDal.Delete(blog);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Blog>> GetAll()
        {
            return new SuccessDataResult<List<Blog>>(_blogDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Blog> GetById(int blogId)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(b=>b.Id==blogId),Messages.Listed);
        }

        public IResult Update(Blog blog)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
