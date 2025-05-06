using bl.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Models
{
    public class BLWorker: IWorkerBl
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string StatusWorker { get; set; } = null!;
        public BLWorker(int id,string name,string email,string password, string statusWorker)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            StatusWorker = statusWorker;
        }
        public BLWorker()
        {
            
        }
    }
}
