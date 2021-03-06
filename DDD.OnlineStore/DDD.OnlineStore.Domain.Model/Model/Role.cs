﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OnlineStore.Domain.Model
{
    public class Role : Entity
    {
        public Role() 
        {
            this.Users = new List<User>();
        }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
        //public virtual ICollection<UserRole> Roles { get; set; }
    }
} 
