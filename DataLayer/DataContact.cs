using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class DataContact
    {

        #region Connection

        private SqlConnection _connection;
        public DataContact(SqlConnection connection)
        {
            _connection = connection;
        }

        #endregion
        public List<Contacts> ListContacts(int id)
        {

            SqlCommand cmd = new SqlCommand("SP_ListContact", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUser", id);


            return ListsAll(cmd);
        }

        public bool AddContact(Contacts contacts)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertContact", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ContactName", contacts.ContactName);
            cmd.Parameters.AddWithValue("@LastName", contacts.LastName);
            cmd.Parameters.AddWithValue("@Adress", contacts.Adress);
            cmd.Parameters.AddWithValue("@PersonalPhone", contacts.PersonalPhone);
            cmd.Parameters.AddWithValue("@WorkPhone", contacts.WorkPhone);
            cmd.Parameters.AddWithValue("@IdUser", contacts.IdUser);
            return ExecuteProc(cmd);
        }


        public bool DeleteContact(int Id)
        {
            SqlCommand cmd = new SqlCommand("SP_DeleteContact", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdContact", Id);

            return ExecuteProc(cmd);
        }

        public bool EditContact(Contacts contacts,int Id)
        {
            SqlCommand cmd = new SqlCommand("SP_UpdateContact", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ContactName", contacts.ContactName);
            cmd.Parameters.AddWithValue("@LastName", contacts.LastName);
            cmd.Parameters.AddWithValue("@Adress", contacts.Adress);
            cmd.Parameters.AddWithValue("@PersonalPhone", contacts.PersonalPhone);
            cmd.Parameters.AddWithValue("@WorkPhone", contacts.WorkPhone);
            cmd.Parameters.AddWithValue("@IdContact", Id);
            return ExecuteProc(cmd);
        }

        #region Execution Commands

        private bool ExecuteProc(SqlCommand proc)
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

        private List<Contacts> ListsAll(SqlCommand proc)
        {
            try
            {
                List<Contacts> contacts = new List<Contacts>();
                SqlDataReader ReadList;

                _connection.Open();

                ReadList = proc.ExecuteReader();

                while (ReadList.Read())
                {
                    contacts.Add(new Contacts
                    {
                        IdContact = ReadList.IsDBNull(0) ? 0 : ReadList.GetInt32(0),
                        ContactName = ReadList.IsDBNull(1) ? "" : ReadList.GetString(1),
                        LastName = ReadList.IsDBNull(2) ? "" : ReadList.GetString(2),
                        Adress = ReadList.IsDBNull(3) ? "" : ReadList.GetString(3),
                        PersonalPhone = ReadList.IsDBNull(4) ? "" : ReadList.GetString(4),
                        WorkPhone = ReadList.IsDBNull(5) ? "" : ReadList.GetString(5)
                    });
                }

                _connection.Close();
                ReadList.Close();
                ReadList.Dispose();
                return contacts;
            }
            catch (Exception ex)
            {
                return null;
            }
            #endregion

        }
    }
}


