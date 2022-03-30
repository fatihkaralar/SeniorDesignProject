using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            GameManager gameManager = new GameManager(new EfGameDal());
            List<Game> _games;
            _games = new List<Game> {

                new Game{ CategoryId=1 , Description="TEST OYUN!", GameName="Irem kayiscissss valorant", Score=0 ,
              WebAddress="dfgdfgfdg" },
                new Game{ CategoryId=1 , Description="It is a fps var game and multiplayer game!", GameName="Valorant", Score=0 ,
              WebAddress="https://playvalorant.com/tr-tr/"  },
                 new Game{ CategoryId=2 , Description="test desc 3!", GameName="FIFA 20", Score=250 ,
              WebAddress="fifa web"  },
                 new Game{CategoryId=8 , Description="test desc 4", GameName="Test Game Name ", Score=200 ,
              WebAddress="minecraft web" ,Image= "Test Image" },

            };
            gameManager.Add(_games[0]);
            foreach (var game in gameManager.GetAll())
            {
               
                Console.WriteLine("Game : "+ game.GameName+ " with category id: "+game.CategoryId+ "Image: "+ game.Image + "Web: "+ game.WebAddress);
            }
            

            
        }
    }
}
