using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Game : IEntity
    {
        public int GameId { get; set; }

        public string GameName { get; set; }

        public string Description { get; set; }

        public string WebAddress { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public int Score { get; set; }


    }
}
