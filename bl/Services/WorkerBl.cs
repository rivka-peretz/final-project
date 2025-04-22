using bl.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dal.Api;

namespace bl.Services
{
    internal class WorkerBl
    {
        dbClass context;
      //IWorkerDal iWorkerDal;
        //public bool CheckingWhetherAnEmployeeExists(int id)
        //{
        //    Worker worker = context.Workers.Find(w => w.Id == id);  
        //    if(worker == null) return false;
        //    return true;
        //}
        public bool AddWorker(int id, string name,int password,string email, string StatusWorker)
        {
            if (id == null || id.ToString().Length>9) return false;
            if (name == null) return false;
            if(password ==null)return false;    
            if (email == null || !IsValidEmail(email)) return false;
           //הוספה ובדיקה אם הוא קיים
            return true ;
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }

    }

