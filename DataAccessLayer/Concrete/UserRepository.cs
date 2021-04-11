using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Entity.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class UserRepository : IRepository<User>
    {
        private readonly ProjectContext _db;
        public UserRepository(ProjectContext db)
        {
            this._db = db;
        }
        public bool Add(User item)
        {
            _db.Users.Add(item);
            return _db.SaveChanges()>0;
        }

        public bool Delete(User item)
        {
            _db.Users.Remove(item);
            return _db.SaveChanges() > 0;
        }

        public List<User> GetAll()
        {
           return _db.Users.ToList();
        }

        public User GetById(int id)
        {
            return _db.Users.Find(id);            
        }

        public bool Update(User item)
        {
            _db.Users.Update(item);
            return _db.SaveChanges() > 0;
        }
    }
}
