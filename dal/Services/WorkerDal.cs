using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal.Models;
using dal.Api;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dal.Services
{
    public class WorkerDal : IWorkerDalService
    {
        private dbClass context;

        public WorkerDal(dbClass dbContext)
        {
            context = dbContext;
        }

        public bool CheckingWhetherTheEmployeeIsAmanager(string password)
        {
            Worker worker = CheckingWhetherAnEmployeeExists(password);
            if (worker == null) return false;

            return worker.StatusWorker.Equals("management");
        }

        public bool AreThereAnyEmployeesInTheSystem()
        {
            return context.Workers.Any();
        }

        public Worker CheckingWhetherAnEmployeeExists(string password)
        {
            return context.Workers.FirstOrDefault(w => w.Password == password);
        }

        public Worker CheckingByIDWhetherTheEmployeeExists(int id)
        {
            return context.Workers.FirstOrDefault(w => w.Id == id);
        }

        public void AddWorker(Worker worker, int teamLeaderId)
        {
            var teamLeader = context.Workers.FirstOrDefault(w => w.Id == teamLeaderId);
            if (teamLeader != null)
            {
                worker.Boss = teamLeader;
            }
            context.Workers.Add(worker);
            context.SaveChanges();
        }

        public void RemoveWorker(Worker worker)
        {
            context.Workers.Remove(worker);
            context.SaveChanges();
        }

        public void Addmanagement(Worker worker)
        {
            context.Workers.Add(worker);
            context.SaveChanges();
        }

        public bool IsITBoss(int Id)
        {
           Worker worker = context.Workers.FirstOrDefault(w => w.Id == Id);
            if (worker == null) return false;
            return worker.StatusWorker.Equals("TeamLeader") || worker.StatusWorker.Equals("Management");
        }
    }
}

