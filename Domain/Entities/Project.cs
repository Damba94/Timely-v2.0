using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; }
        public DateTime Duration    { get; set; }   
        public AppUser appUser { get; set; }    
    }
}
