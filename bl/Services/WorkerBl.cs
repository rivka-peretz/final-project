using bl.Models;
using System.Text.RegularExpressions;
using dal.Api;
using bl.Api;

namespace bl.Services
{
    public class WorkerBl:IBlWorkerService
    {
        private IWorkerDalService _iworkerDal;
        public bool AddWorker(IWorkerBl worker, string AdministratorPassword)
        {
            if (_iworkerDal.CheckingWhetherAnEmployeeExists(worker.Password) != null) return false;
            if (!_iworkerDal.CheckingWhetherTheEmployeeIsAmanager(AdministratorPassword)) return false;
            if (worker.Id == null || worker.Id.ToString().Length>9) return false;
            if (worker.Name == null) return false;
            if(worker.Password ==null)return false;    
            if (worker.Email == null || !IsValidEmail(worker.Email)) return false;
            Worker workerDAL = (Worker)worker;
            //worker1.Email = worker.Email;
            //worker1.Password = worker.Password;
            //worker1.Id = worker.Id;
            //worker1.Name = worker.Name;
            //worker1.StatusWorker = worker.StatusWorker;
            _iworkerDal.AddWorker(workerDAL);
            return true ;
        }
        public bool Addmanagement(IWorkerBl worker)
        {
            if (!_iworkerDal.AreThereAnyEmployeesInTheSystem())
            {
                Worker workerDAL = (Worker)worker;
                _iworkerDal.Addmanagement(workerDAL);
                return true ;
            }
            return false ; 
        }
        public bool RemoveWorker(int id, string AdministratorPassword)
        {
            if (!_iworkerDal.CheckingWhetherTheEmployeeIsAmanager(AdministratorPassword)) return false;
            Worker worker = _iworkerDal.CheckingByIDWhetherTheEmployeeExists(id);
            if (worker == null)return false;
            _iworkerDal.RemoveWorker(worker);
            return true;
        }
        public BLWorker GetWorker(int id)
        {
         Worker w =  _iworkerDal.CheckingByIDWhetherTheEmployeeExists(id);
            return new(w.Id, w.Name, w.Email, w.Password, w.StatusWorker);  
        }
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        public bool AddWorker(BLWorker worker, string AdministratorPassword)
        {
            throw new NotImplementedException();
        }
    }
    }

