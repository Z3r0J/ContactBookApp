using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Contacts
    {
        public int IdContact { get; set; }
        public string ContactName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PersonalPhone { get; set; }
        public string WorkPhone { get; set; }
    }
}
