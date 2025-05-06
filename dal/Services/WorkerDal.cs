using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl.Models;
using dal.Api;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dal.Services
{

    internal class WorkerDal: IWorkerDalService
    {
        dbClass context;
        IWorkerDalService iWorkerDal;
        public bool CheckingWhetherTheEmployeeIsAmanager(string password)
        {
            Worker worker = CheckingWhetherAnEmployeeExists(password);
            if(worker == null) return false;
            if (worker.StatusWorker.Equals("management"))
            {
                return true;
            }
            return false;
        }

        public Worker CheckingWhetherAnEmployeeExists(string password)
        {
            return context.Workers.FirstOrDefault(w => w.Password == password);
        }
        public Worker CheckingByIDWhetherTheEmployeeExists(int id)
        {
            return context.Workers.FirstOrDefault(w => w.Id == id);
        }

        public void AddWorker(Worker worker)
        {
            context.Workers.Add(worker);
            context.SaveChanges(); 
        }
        public void RemoveWorker(int id )
        {
            context.Workers.Remove(CheckingByIDWhetherTheEmployeeExists(id));
            context.SaveChanges();
        }
    }
}
