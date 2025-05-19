using bl.Models;
using dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Services
{
    internal class TaskBL : IBLTaskService
    {
        ITaskDALService _ItaskDAL;
        IProjectDalService _IprojectDAL;
        IWorkerDalService _IworkerDAL;

        public bool DeleteTask(string nameProject, string nameTask, string AdministratorPassword)
        {
            if (!_IworkerDAL.CheckingWhetherTheEmployeeIsAmanager(AdministratorPassword)) return false;
            BLProject project = _IprojectDAL.SearchForAProjectByName(nameProject);
            BLTask task = _ItaskDAL.SearchForATaskByName(nameTask);
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
