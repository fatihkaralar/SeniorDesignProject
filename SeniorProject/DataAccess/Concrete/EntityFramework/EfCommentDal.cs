using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : ICommentDal
    {
        public void Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment Get(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
