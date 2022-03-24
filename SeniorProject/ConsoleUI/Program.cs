using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            GameManager gameManager = new GameManager(new InMemoryGameDal());

            foreach (var game in gameManager.GetAll())
            {
                Console.WriteLine(" Game Name: "+ game.GameName+ "\n Game description: "+ game.Description +"\n Web address: "+ game.WebAddress+ "\n\n");
            }
            Console.WriteLine("----------------------------------------------------------");
            foreach (var game in gameManager.GetAllByCategory(1))
            {
                Console.WriteLine(" Game Name: " + game.GameName + "\n Game description: " + game.Description + "\n Web address: " + game.WebAddress + "\n Category: "+ game.CategoryId+ "\n\n");
            }

            
        }
    }
}
