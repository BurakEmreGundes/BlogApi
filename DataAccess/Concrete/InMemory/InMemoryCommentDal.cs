﻿using Core.DataAccess.InMemory;
using Core.Utilities.Results;
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
    public class InMemoryCommentDal :InMemoryEntityRepositoryBase <Comment>,ICommentDal
    {
        public InMemoryCommentDal(List<Comment> comments):base(comments)
        {

        }

    }
}
