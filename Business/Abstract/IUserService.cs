using Entity.Concrete.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService<T>:IService<T> where T :class
    {
        public List<T> Any();       

    }
}
