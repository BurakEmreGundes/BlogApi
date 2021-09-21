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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Comment comment)
        {
            _commentDal.Delete(comment);
            return new ErrorResult(Messages.Deleted);
        }

        public IDataResult<List<Comment>> GetAll()
        {  
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Comment> GetById(int id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(c=>c.Id==id));
        }

        public IDataResult<List<Comment>> GetCommentsByBlogId(int blogId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(b=>b.Id==blogId),Messages.Listed);
        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult(Messages.Updated);

        }
    }
}
