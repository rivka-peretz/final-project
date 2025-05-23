using bl.Models;
using System.Text.RegularExpressions;
using dal.Api;
using bl.Api;
using dal.Models;

namespace bl.Services
{
    public class WorkerBl : IBlWorkerService
    {
        private IWorkerDalService _iworkerDal;
           public WorkerBl(IWorkerDalService iworkerDal)
    {
        _iworkerDal = iworkerDal ;
    }
        public bool AddWorker(BLWorker worker, int TeamLeaderId)
        {
            ///צריך להוסיף מה יקרה אם הוא ראש צוות
            if (!_iworkerDal.IsITTeamLeader(TeamLeaderId)) return false;
            if (_iworkerDal.CheckingWhetherAnEmployeeExists(worker.Password) != null) return false;
            if (worker.Id == null || worker.Id.ToString().Length > 9) return false;
            if (worker.Name == null) return false;
            if (worker.Password == null) return false;
            if (worker.Email == null || !IsValidEmail(worker.Email)) return false;

            Worker workerDAL = new Worker();
            _iworkerDal.AddWorker(workerDAL, TeamLeaderId);
            return true;
        }
        public bool Addmanagement(BLWorker worker)
        {
            if (!_iworkerDal.AreThereAnyEmployeesInTheSystem())
            {
                Worker workerDAL =new Worker();
                _iworkerDal.Addmanagement(workerDAL);
                return true;
            }
            return false;
        }

        public bool AreThereAnyEmployeesInTheSystem()
        {
            return _iworkerDal.AreThereAnyEmployeesInTheSystem();
        }
        public bool RemoveWorker(int id)
        {
            Worker worker = _iworkerDal.CheckingByIDWhetherTheEmployeeExists(id);
            if (worker == null) return false;
            _iworkerDal.RemoveWorker(worker);
            return true;
        }
        public BLWorker GetWorker(int id)
        {
            Worker w = _iworkerDal.CheckingByIDWhetherTheEmployeeExists(id);
            return new(w.Id, w.Name, w.Email, w.Password, w.StatusWorker);
        }
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        //public List<IBLTask> ViewTheWorkerTasks(int WorkerID)
        //{
        //    // כאן תוכל להוסיף את הלוגיקה להחזרת המשימות של העובד
        //    return _iworkerDal.GetTasksByWorkerId(WorkerID);
        //}
    }
}