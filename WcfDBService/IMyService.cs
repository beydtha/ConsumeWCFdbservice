using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfDBService.EF;

namespace WcfDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        List<userdetail> GetAllUser();
        [OperationContract]
        int AddUser(string name, string email, int deptID);
        [OperationContract]
        userdetail GetUserdetailbyId(int id);

        [OperationContract]
        int DeleteUserById(int Id);
        [OperationContract]
        int UpdateUser(int id, string name, string email);
        void DoWork();


    }
    [DataContract]
    public class UserDetails
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
