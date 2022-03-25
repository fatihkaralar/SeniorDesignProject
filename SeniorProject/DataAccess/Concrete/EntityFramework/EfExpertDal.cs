using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExpertDal : IExpertDal
    {
        public void Add(Expert entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expert entity)
        {
            throw new NotImplementedException();
        }

        public Expert Get(Expression<Func<Expert, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Expert> GetAll(Expression<Func<Expert, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Expert entity)
        {
            throw new NotImplementedException();
        }
    }
}
