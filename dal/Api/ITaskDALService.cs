using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Api
{
    public interface ITaskDALService
    {
        public void AddTask(Task task);
        public Task SearchForATaskByName(string name);
        public void RemoveTask(Task task);
    }
}
