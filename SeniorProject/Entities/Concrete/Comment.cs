using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Comment : IEntity 
    {
        public int CommentId { get; set; }

        public int GameId { get; set; }

        public int UserId { get; set; } //This user ıd may be both parent or child development expert.

        public int Score { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
