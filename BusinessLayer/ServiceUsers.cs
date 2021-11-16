using System;
using DataLayer;
using DataLayer.Models;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class ServiceUsers
    {
        #region Services
        private DataUsers dataUsers;
        public ServiceUsers(SqlConnection connection)
        {
            dataUsers = new DataUsers(connection);
        }
        #endregion

        #region Business Logic
        public Users S_LoginUsers(string userName, string Password)
        {
            return dataUsers.LoginUser(userName, Password);
        }

        public Users ValidateExistUser(string UserName)
        {

            return dataUsers.ValidateExistRegister(UserName);
        }
        public bool S_RegisterUsers(Users item) {

            return dataUsers.RegisterUser(item);
        }
        #endregion
    }
}
