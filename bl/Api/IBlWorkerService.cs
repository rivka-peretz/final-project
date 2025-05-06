using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    public interface IBlWorkerService
    {
        public bool AddWorker(BLWorker worker, string AdministratorPassword);
        public bool RemoveWorker(int id, string AdministratorPassword);
        public BLWorker GetWorker(int id);
    }
}
