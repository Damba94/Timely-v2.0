using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TimelyContext : IdentityDbContext<AppUser>
{
    public TimelyContext(DbContextOptions options) : base(options)
    {
                
    }
    
    public DbSet<Project> Projects { get; set; }
    }

