using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IChildDal
    {
        List<Child> GetAll();

        void Add(Child child);

        void Update(Child child);

        void Delete(Child child);

        List<Child> GetById(int childId);

        List<Child> GetAllByParentId(int parentId);


    }
}
