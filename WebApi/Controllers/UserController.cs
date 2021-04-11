using Business.Abstract;
using Business.Concrete;
using Entity.Concrete;
using Entity.Concrete.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService<UserDto> _usService;
        public UserController(IUserService<UserDto> usService)
        {
            _usService = usService;
        }
        [HttpGet]
        public List<UserDto> ViewCustomer()
        {
          return  _usService.GetAll();

        }
    }
}
