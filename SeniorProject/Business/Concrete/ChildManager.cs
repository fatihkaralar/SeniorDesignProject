using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ChildManager : IChildService
    {
        IChildDal _childDal;

        public ChildManager(IChildDal childDal)
        {
            _childDal = childDal;
        }

        public void Add(Child child)
        {
            _childDal.Add(child);
        }

        public void Delete(Child child)
        {
            _childDal.Delete(child);
        }

        public List<Child> GetAll()
        {
            return _childDal.GetAll();
        }

        public Child GetById(int childId)
        {
            return _childDal.Get(c=>c.ChildId==childId);
        }

        public void Update(Child child)
        {
            _childDal.Update(child);
        }
    }
}
