using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService <T> where T :class
    {
        public List<T> GetAll();
        public T GetById(int id);
        public bool Add(T item);
        public bool Update(T item);
        public bool Delete(T item);
    }
}
