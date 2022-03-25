using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChildDal : IChildDal
    {
        public void Add(Child entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Child entity)
        {
            throw new NotImplementedException();
        }

        public Child Get(Expression<Func<Child, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Child> GetAll(Expression<Func<Child, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Child entity)
        {
            throw new NotImplementedException();
        }
    }
}
