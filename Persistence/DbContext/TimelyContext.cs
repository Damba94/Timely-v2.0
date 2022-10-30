using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TimelyContext:DbContext
    {
        public TimelyContext(DbContextOptions<TimelyContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
    }

