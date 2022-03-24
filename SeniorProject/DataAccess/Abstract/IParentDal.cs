using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IParentDal
    {
        List<Parent> GetByChildId(int childId);

        List<Parent> GetById(int commentId);

        List<Parent> GetAll();

        void Add(Parent comment);

        void Delete(Parent comment);

        void Update(Parent comment);

        
    }
}
