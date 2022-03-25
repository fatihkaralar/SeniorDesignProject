using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGameDal : IGameDal
    {
        public void Add(Game entity)
        {
            //IDisposable pattern implementation of c#
            using (ProjectDbContext context=new ProjectDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Game entity)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Game Get(Expression<Func<Game, bool>> filter)
        {
            using (ProjectDbContext context=new ProjectDbContext())
            {
                return context.Set<Game>().SingleOrDefault(filter);
            }
        }

        public List<Game> GetAll(Expression<Func<Game, bool>> filter = null)
        {
            using (ProjectDbContext context=new ProjectDbContext())
            {
                
                return filter == null 
                       ? context.Set<Game>().ToList() :
                       context.Set<Game>().Where(filter).ToList();
            }
        }

        public void Update(Game entity)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var upatedEntity = context.Entry(entity);
                upatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
