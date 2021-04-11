﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Entity
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleInfo { get; set; }
    }

}
