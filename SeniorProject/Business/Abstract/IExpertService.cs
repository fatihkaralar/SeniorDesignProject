using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExpertService
    {
        List<Expert> GetAll();

        Expert GetById(int expertId);

        void Add(Expert expert);

        void Delete(Expert expert);

        void Update(Expert expert);

    }
}
