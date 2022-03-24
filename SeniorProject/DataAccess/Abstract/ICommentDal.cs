using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICommentDal
    {
        List<Comment> GetAllByGameId(int gameId);

        void Add(Comment comment);

        void Delete(Comment comment);

        void Update(Comment comment);

        List<Comment> GetById(int commentId);

        List<Comment> GetAll();



    }
}
