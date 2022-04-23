using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IChildService
    {

        List<Child> GetAll();

        Child GetById(int childId);

        void Add(Child child);

        void Delete(Child child);

        void Update(Child child);

    }
}
