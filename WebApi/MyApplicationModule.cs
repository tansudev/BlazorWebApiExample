using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Concrete.DTO;
using Entity.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApi
{
    public class MyApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            builder.RegisterType<UserRepository>()
               .As<IRepository<User>>().InstancePerLifetimeScope();

            builder.RegisterType<UserService>()
                .As<IUserService<UserDto>>().InstancePerLifetimeScope();

        }
    }
}
