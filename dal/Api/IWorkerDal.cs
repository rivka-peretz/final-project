using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl.Models;

namespace dal.Api
{
    internal interface IWorkerDal
    {
        public void AddWorker(Worker worker);
    }
}
