using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGameService
    {
        List<Game> GetAll();

        void Add(Game game);

        void Delete(Game game);

        void Update(Game game);

        List<Game> GetAllByCategory(int categoryId);

    }
}
