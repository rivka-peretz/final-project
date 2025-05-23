using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace bl.Api
    {
        public interface IBlWorkerService
        {
            public bool AreThereAnyEmployeesInTheSystem();
            public bool AddWorker(BLWorker worker, int TeamLeaderId);
            public bool Addmanagement(BLWorker worker);
            public bool RemoveWorker(int id);
            public BLWorker GetWorker(int id);
            //public List<IBLTask> ViewTheWorkerTasks(int WorkerID);
        }
    }

