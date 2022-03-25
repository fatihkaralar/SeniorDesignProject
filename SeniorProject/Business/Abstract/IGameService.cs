using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGameService
    {
        List<Game> GetAll();

        List<Game> GetAllByCategory(int id);

        void Add(Game game);

        void Delete(Game game);

        void Update(Game game);

       

    }
}
