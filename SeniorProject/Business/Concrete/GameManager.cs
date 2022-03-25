using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {

        IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
        }

        public List<Game> GetAll()
        {
           return _gameDal.GetAll();
        }

        public List<Game> GetAllByCategory(int id)
        {
            return _gameDal.GetAll(g => g.CategoryId == id);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
