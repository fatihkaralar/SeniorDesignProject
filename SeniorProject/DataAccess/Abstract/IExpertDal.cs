using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IExpertDal
    {
        List<Expert> GetAll();

        void Add(Expert expert);

        void Update(Expert expert);

        void Delete(Expert expert);

        List<Expert> GetById(int expertId);
    }
}
