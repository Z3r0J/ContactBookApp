using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactBookApp
{

    public partial class FrmContactList : Form
    {
        DataTable dt;
        ServiceContact _service;
        public int IdLogged { get; set; } = 1;
        public FrmContactList()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            SqlConnection _connection = new SqlConnection(connectionString);
            _service = new ServiceContact(_connection);
        }

        #region Method


        public void DesignDtgv()
        {
            DtgvContacts.Columns[0].Width = 80;
            DtgvContacts.Columns[1].Width = 110;
            DtgvContacts.Columns[2].Width = 120;
            DtgvContacts.Columns[3].Width = 250;

        }
        private void FillDgv()
        {

            DtgvContacts.DataSource = _service.ListContact(IdLogged);
            DtgvContacts.ClearSelection();
        }

        #endregion

        private void FrmContactList_Load(object sender, EventArgs e)
        {
            FillDgv();
            DesignDtgv();
        }
    }


}
