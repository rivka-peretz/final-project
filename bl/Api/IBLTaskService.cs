using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    public interface IBLTaskService
    {
        public bool DeleteTask(string nameProject, string nameTask, string AdministratorPassword);
        public bool AddTask();


    }
}
