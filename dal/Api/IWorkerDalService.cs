using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl.Models;

namespace dal.Api
{
    public interface IWorkerDalService
    {
        public void AddWorker(Worker worker);
        public Worker CheckingWhetherAnEmployeeExists(string password);
        public bool CheckingWhetherTheEmployeeIsAmanager(string password);
        public Worker CheckingByIDWhetherTheEmployeeExists(int id);
        public void RemoveWorker(int id);
    }
}
