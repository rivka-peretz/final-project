using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl
{
    internal class DalToBL
    {
        public BLWorker WorkerBlToDal(Worker  worker)
        {
            BLWorker worker1 = new BLWorker();
            worker1.Email = worker.Email;
            worker1.Name = worker.Name;
            worker1.Password = worker.Password;
            worker1.Id = worker.Id;
            worker1.StatusWorker = worker.StatusWorker;
            return worker1;
        }

    }
}
