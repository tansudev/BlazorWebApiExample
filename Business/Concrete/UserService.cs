using Business.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete.DTO;
using Entity.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService: IUserService<UserDto> 
    {
        User user = new User();
        UserDto userDto = new UserDto();
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            this._repository = repository;
        }
        public bool Add(UserDto item)
        {
            user.Id = item.Id;
            user.Name = item.Name;
            user.Surname = item.Surname;
            user.Email = item.Email;
            user.Password = item.Password;
            user.UserRoleId = 2;

          return  _repository.Add(user);
           
        }

        public List<UserDto> Any()
        {
            throw new NotImplementedException();
        }

        public bool Delete(UserDto item)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAll()
        {
            List<User> usList = _repository.GetAll();

            List<UserDto> usDtoList = new List<UserDto>();

            foreach (var item in usList )
            {
                userDto.Id = item.Id;
                userDto.Name = item.Name;
                userDto.Surname = item.Surname;
                userDto.Email = item.Email;
                userDto.Password = item.Password;

                usDtoList.Add(userDto);
            }

            return usDtoList;
        }

        public UserDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserDto item)
        {
            throw new NotImplementedException();
        }
    }
}
