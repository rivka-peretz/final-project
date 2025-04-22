using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl.Models;
using dal.Api;

namespace dal.Services
{

    internal class WorkerDal: IWorkerDal
    {
        dbClass context;
        public void AddWorker(Worker worker)
        {
            context.Workers.Add(worker);
        }
    }
}
