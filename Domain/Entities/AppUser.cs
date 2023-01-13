﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppUser: IdentityUser
    {
        public string DisplayName { get; set; } 
         public List<Project> Projects { get; set; }

    }
}
