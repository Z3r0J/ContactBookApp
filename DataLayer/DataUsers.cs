using DataLayer.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataUsers
    {
        #region Connection

        private SqlConnection _connection;
        public DataUsers(SqlConnection connection)
        {
            _connection = connection;
        }

        #endregion

        #region Methods
        public bool RegisterUser(Users users)
        {
            SqlCommand cmd = new SqlCommand("SP_RegisterUser", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", users.Name);
            cmd.Parameters.AddWithValue("@LastName", users.LastName);
            cmd.Parameters.AddWithValue("@UserName", users.UserName);
            cmd.Parameters.AddWithValue("@Password", users.Password);

            return ExecuteProc(cmd);
        }

        public Users LoginUser(string UserName, string Password)
        {
            try
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand("SP_LoginUser", _connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password",Password);

                SqlDataReader reader = cmd.ExecuteReader();

                Users users = new Users();
                if (reader.Read())
                {
                    users.IdUser = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    users.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    users.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    _connection.Close();
                    reader.Close();
                    reader.Dispose();
                    return users;
                }
                else
                {
                    _connection.Close();
                    reader.Close();
                    reader.Dispose();
                    return null;
                }
                 
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Users ValidateExistRegister(string UserName)
        {
            try
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand("SP_ExistUser", _connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", UserName);

                SqlDataReader reader = cmd.ExecuteReader();

                Users users = new Users();
                if (reader.Read())
                {
                    users.IdUser = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    users.UserName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    _connection.Close();
                    reader.Close();
                    reader.Dispose();
                    return users;
                }
                else
                {
                    _connection.Close();
                    reader.Close();
                    reader.Dispose();
                    return null;
                }

            }
            catch (Exception ex)
            {

                return null;
            }
        }


        #endregion

        #region Execution Commands

        public bool ExecuteProc(SqlCommand proc)
        {

            try
            {
                _connection.Open();

                proc.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        #endregion


    }
}
