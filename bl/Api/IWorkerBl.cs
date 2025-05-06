using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    public interface IWorkerBl
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; } 
        public string StatusWorker { get; set; } 
    }

}
