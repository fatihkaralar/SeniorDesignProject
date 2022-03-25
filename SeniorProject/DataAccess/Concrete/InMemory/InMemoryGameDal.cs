using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGameDal : IGameDal
    {

        List<Game> _games;

        public InMemoryGameDal()
        {
            _games = new List<Game> {
            
                new Game{GameId=1, CategoryId=1 , Description="It is a war game and there are lots of violence!", GameName="Call Of Duty", Score=0 , 
              WebAddress="https://www.callofduty.com/" },
                new Game{GameId=2, CategoryId=1 , Description="It is a fps var game and multiplayer game!", GameName="Valorant", Score=0 ,
              WebAddress="https://playvalorant.com/tr-tr/"  },
                 new Game{GameId=3, CategoryId=2 , Description="test desc 3!", GameName="FIFA 20", Score=250 ,
              WebAddress="fifa web"  },
                 new Game{GameId=4, CategoryId=3 , Description="test desc 4", GameName="Minecraft", Score=200 ,
              WebAddress="minecraft web"  },

            };
        }

        public void Add(Game game)
        {
            _games.Add(game);
        }

        public void Delete(Game game)
        {
            //LINQ - Language Integrated Query

            Game gameToDelete = _games.SingleOrDefault(g=>g.GameId==game.GameId);
            
            _games.Remove(gameToDelete);
        }

        public Game Get(Expression<Func<Game, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            return _games;
        }

        public List<Game> GetAll(Expression<Func<Game, bool>> filter = null)
        {
            return null;
        }

        public List<Game> GetAllByCategory(int categoryId)
        {
            return _games.Where(g => g.CategoryId == categoryId).ToList();
        }

        public void Update(Game game)
        {
            Game gameToUpdate = _games.SingleOrDefault(g => g.GameId == game.GameId);
            gameToUpdate.CategoryId = game.CategoryId;
            gameToUpdate.GameName = game.GameName;
            gameToUpdate.Score = game.Score;

        }
    }
}
