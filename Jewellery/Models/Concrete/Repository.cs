using Jewellery.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Concrete
{
    public class Repository<T> : IAll<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
        }


        public void Added(T t)
        {
            var entity = context.Entry(t);
            entity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Deleted(T t)
        {
            var entity = context.Entry(t);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GotAll()
        {
            return _object.ToList();
        }

        public void Updated(T t)
        {
            var entity = context.Entry(t);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}