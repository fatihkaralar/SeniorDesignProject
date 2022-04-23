using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IParentService
    {
        List<Parent> GetAll();

        Parent GetById(int parentId);

        void Add(Parent parent);

        void Delete(Parent parent);

        void Update(Parent parent);


    }
}
