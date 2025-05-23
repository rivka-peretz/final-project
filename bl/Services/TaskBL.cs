using bl.Api;
using dal.Api;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = dal.Models.Task;//לבדוק...

namespace bl.Services
{
    public class TaskBL : IBLTaskService
    {
        ITaskDALService _ItaskDAL;
        IProjectDalService _IprojectDAL;
        IWorkerDalService _IworkerDAL;

        public bool DeleteTask(string nameProject, string nameTask, string AdministratorPassword)
        {
            if (!_IworkerDAL.CheckingWhetherTheEmployeeIsAmanager(AdministratorPassword)) return false;
           Project project = _IprojectDAL.SearchForAProjectByName(nameProject);
           Task task = _ItaskDAL.SearchForATaskByName(nameTask);
            if (task == null) return false;
            if (project == null) return false;
            _ItaskDAL.RemoveTask(task);
            return true;
        }
        public bool AddTask()
        {
            return true;
        }

    }
}
