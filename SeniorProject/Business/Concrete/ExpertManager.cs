using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExpertManager : IExpertService
    {
        //Dependency Injection
        IExpertDal _expertDal;

        public ExpertManager(IExpertDal expertDal)
        {
            _expertDal = expertDal;
        }

        public void Add(Expert expert)
        {
            _expertDal.Add(expert);
        }

        public void Delete(Expert expert)
        {
            _expertDal.Delete(expert);
        }

        public List<Expert> GetAll()
        {
            return _expertDal.GetAll();
        }

        public Expert GetById(int expertId)
        {
            return _expertDal.Get(e => e.ExpertId == expertId);
        }

        public void Update(Expert expert)
        {
            _expertDal.Update(expert);
        }
    }
}
