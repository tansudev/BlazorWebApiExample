using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProjectContext _db;

        public Repository(ProjectContext db)
        {
            this._db = db;
        }
        public bool Add(T item)
        {
            _db.Set<T>().Add(item);
            return _db.SaveChanges() > 0;
        }

        public bool Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
