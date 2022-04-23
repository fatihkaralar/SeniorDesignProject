using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Business operations of Parent table.

    public class ParentManager : IParentService
    {
        IParentDal _parentDal;

        public ParentManager(IParentDal parentDal)
        {
            _parentDal = parentDal;
        }

        public void Add(Parent parent)
        {
            _parentDal.Add(parent);
        }

        public void Delete(Parent parent)
        {
            _parentDal.Delete(parent);
        }

        public List<Parent> GetAll()
        {
            return  _parentDal.GetAll();
        }

        public Parent GetById(int parentId)
        {
            return _parentDal.Get(p=> p.ParentId==parentId);
        }

        public void Update(Parent parent)
        {
            _parentDal.Update(parent);
        }
    }
}
