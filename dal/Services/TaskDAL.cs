using dal.Models;
using dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dal.Services
{
    public class TaskDAL:ITaskDALService
    {
        dbClass context;

        public void AddTask(Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }
        public Task SearchForATaskByName(string name)//לבדוק אם צריך פונקציית חיפוש ואם כן לברר לפי מה נחפש
        {
               return context.Tasks.FirstOrDefault(p => p.Title == name);
        }
        public void RemoveTask(Task task)
        {
            context.Tasks.Remove(task);
            context.SaveChanges();
        }
    }
}
