using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfDBService.EF;
namespace WcfDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
   
        public int AddUser(string name, string email, int deptID)
        {
            var db = new EModel();
            var ud = new userdetail();
            ud.Name = name;
            ud.email = email;
            ud.Deptid = deptID;
            db.userdetail.Add(ud);
            int retval = db.SaveChanges();
            return retval;
        }

        public int DeleteUserById(int Id)
        {
            var db = new EModel();
            userdetail ud = new userdetail();
            ud.UserID = Id;
            db.Entry(ud).State = EntityState.Deleted;
            int retVal = db.SaveChanges();
            return retVal; 
        }

        public void DoWork()
        {
        }

      
        public userdetail GetUserdetailbyId(int id)
        {
            var db = new EModel();
            var usr = from k in db.userdetail where k.UserID == id select k;
            var user = new userdetail();
            foreach (var item in usr)
            {

                user.Name = item.Name;
                user.email = item.email;
                user.Deptid = item.Deptid;       

            }
            return user; 
        }

       public  List<userdetail> GetAllUser()
        {
            List<userdetail> userList = new List<userdetail>();
            EModel db = new EModel();
            var urList = from k in db.userdetail select k;
            foreach (var item in urList)
            {
                var usr = new userdetail();
                usr.Name = item.Name;
                usr.email = item.email;
                usr.Deptid = item.Deptid;
                userList.Add(usr);

            }

            return userList;
        }

        public int UpdateUser(int id, string name, string email)
        {

            var db = new EModel();
            var ud = new userdetail();
            ud.UserID = id;
            ud.email = email;
            ud.Name = name;
            db.Entry(ud).State = EntityState.Modified; 

            int retVal = db.SaveChanges();
            return retVal; 
        }
    }
}
