using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal.Models;

namespace dal.Api
{
    public interface IWorkerDalService
    {
        public void AddWorker(Worker worker, int TeamLeaderId);
        public Worker CheckingWhetherAnEmployeeExists(string password);
        public bool CheckingWhetherTheEmployeeIsAmanager(string password);
        public bool AreThereAnyEmployeesInTheSystem();
        public void Addmanagement(Worker worker);
        public Worker CheckingByIDWhetherTheEmployeeExists(int id);
        public void RemoveWorker(Worker worker);
        public bool IsITBoss(int Id);
    }
}
