using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGameDal
    {
        List<Game> GetAll();

        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);

        List<Game> GetAllByCategory(int categoryId);    

    }
}
