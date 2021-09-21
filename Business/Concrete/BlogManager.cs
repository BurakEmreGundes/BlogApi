using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
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
            var context = new ValidationContext<Blog>(blog);
            BlogValidator blogValidator = new BlogValidator();
            var result=blogValidator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _blogDal.Add(blog);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Blog blog)
        {
            var context = new ValidationContext<Blog>(blog);
            BlogValidator blogValidator = new BlogValidator();
            var result = blogValidator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _blogDal.Delete(blog);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Blog>> GetAll()
        {
            return new SuccessDataResult<List<Blog>>(_blogDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Comment>> GetBlogComments(int blogId)
        {
            return new SuccessDataResult<List<Comment>>(_blogDal.GetBlogComments(blogId));
        }

        public IDataResult<Blog> GetById(int blogId)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(b=>b.Id==blogId),Messages.Listed);
        }

        public IResult Update(Blog blog)
        {
            var context = new ValidationContext<Blog>(blog);
            BlogValidator blogValidator = new BlogValidator();
            var result = blogValidator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _blogDal.Update(blog);
            return new SuccessResult(Messages.Updated);
        }
    }
}
