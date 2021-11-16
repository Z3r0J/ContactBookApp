using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class ServiceContact
    {
        #region Services
        private DataContact dataContact;
        public ServiceContact(SqlConnection connection)
        {
            dataContact = new DataContact(connection);
        }
        #endregion

        public List<Contacts> ListContact(int id)
        {

            return dataContact.ListContacts(id);
        }

        public bool AddContact(Contacts contacts)
        {
            return dataContact.AddContact(contacts);
        }


        public bool EditContact(Contacts contacts, int Id)
        {
            return dataContact.EditContact(contacts,Id);
        }

        public bool DeleteContact(int Id) {
            return dataContact.DeleteContact(Id);
        }
    }
}
