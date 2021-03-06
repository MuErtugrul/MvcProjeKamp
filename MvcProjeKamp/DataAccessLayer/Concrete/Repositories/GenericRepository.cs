using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            //throw new NotImplementedException();
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            //throw new NotImplementedException();
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            //throw new NotImplementedException();
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            //throw new NotImplementedException();
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            //throw new NotImplementedException();
            c.SaveChanges();
        }
    }
}
