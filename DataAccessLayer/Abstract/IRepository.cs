using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository <T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public bool Add(T item);
        public bool Update(T item);
        public bool Delete(T item);
    }
}
