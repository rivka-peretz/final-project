using bl.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dal.Api;
using dal.Services;
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
            Worker worker1 = new Worker();
            worker1.Email = worker.Email;
            worker1.Password = worker.Password;
            worker1.Id = worker.Id;
            worker1.Name = worker.Name;
            worker1.StatusWorker = worker.StatusWorker;
            _iworkerDal.AddWorker(worker1);
            return true ;
        }
        public bool RemoveWorker(int id, string AdministratorPassword)
        {
            if (!_iworkerDal.CheckingWhetherTheEmployeeIsAmanager(AdministratorPassword)) return false;
            Worker worker = _iworkerDal.CheckingByIDWhetherTheEmployeeExists(id);
            if (worker == null)return false;
            _iworkerDal.RemoveWorker(id);
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

