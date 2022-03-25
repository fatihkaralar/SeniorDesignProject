using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfParentDal : IParentDal
    {
        public void Add(Parent entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Parent entity)
        {
            throw new NotImplementedException();
        }

        public Parent Get(Expression<Func<Parent, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAll(Expression<Func<Parent, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Parent entity)
        {
            throw new NotImplementedException();
        }
    }
}
