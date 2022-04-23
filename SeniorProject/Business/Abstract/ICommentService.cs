using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();

        Comment GetById(int commentId);

        void Add(Comment comment);

        void Delete(Comment comment);

        void Update(Comment comment);
    }
}
