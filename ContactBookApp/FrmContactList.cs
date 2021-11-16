using BusinessLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ContactBookApp
{

    public partial class FrmContactList : Form
    {
        ServiceContact _service;

        public char BlackAndLight { get; set; } = 'L';
        public int IdLogged { get; set; }
        public FrmContactList()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            SqlConnection _connection = new SqlConnection(connectionString);
            _service = new ServiceContact(_connection);
        }

        #region DLLFORTHEBAR

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        #endregion


        #region Events
        private void BtnDarkAndLight_Click(object sender, EventArgs e)
        {
            SwitchTheme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmContactList_Load(object sender, EventArgs e)
        {
            FillDgv();
            DesignDtgv();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            DtgvContacts.ClearSelection();
            BtnDeselect.Visible = false;
        }

        private void DtgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnDeselect.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteContact();
            FillDgv();
        }
        #endregion

        #region Method

        private void SwitchTheme()
        {

            if (BlackAndLight == 'L')
            {
                BlackAndLight = 'D';
                BtnDarkAndLight.Text = "Dark 🌑";
                DtgvContacts.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
                DtgvContacts.DefaultCellStyle.ForeColor = Color.White;
                DtgvContacts.BackgroundColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));

                BtnAddContact.Image = Properties.Resources.add_black;
                BtnEdit.Image = Properties.Resources.edit_black;
                BtnDelete.Image = Properties.Resources.delete_black;
                BtnDeselect.Image = Properties.Resources.deselect_black;

                this.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
                this.ForeColor = Color.White;
                pictureBox1.Image = Properties.Resources.close_dark;
            }

            else
            {
                BlackAndLight = 'L';
                BtnDarkAndLight.Text = "Light ☀";
                DtgvContacts.DefaultCellStyle.BackColor = Color.White;
                DtgvContacts.DefaultCellStyle.ForeColor = Color.Gray;
                DtgvContacts.BackgroundColor = Color.White;

                BtnAddContact.Image = Properties.Resources.add_white;
                BtnEdit.Image = Properties.Resources.edit_white;
                BtnDelete.Image = Properties.Resources.delete_white;
                BtnDeselect.Image = Properties.Resources.deselect_white;

                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                pictureBox1.Image = Properties.Resources.close32;
            }
        }

        public void DesignDtgv()
        {
            DtgvContacts.Columns[0].Width = 80;
            DtgvContacts.Columns[1].Width = 110;
            DtgvContacts.Columns[2].Width = 120;
            DtgvContacts.Columns[3].Width = 250;
            DtgvContacts.Columns[6].Visible = false;
            DtgvContacts.ClearSelection();
        }
        private void FillDgv()
        {

            DtgvContacts.DataSource = _service.ListContact(IdLogged);
        }

        private void Edit()
        {

            if (DtgvContacts.SelectedRows.Count > 0)
            {
                FrmAddContact frm = new FrmAddContact();
                frm.Edit = true;
                frm.IdLogged = IdLogged;
                frm.IdContact = Convert.ToInt32(DtgvContacts.CurrentRow.Cells[0].Value.ToString());
                frm.TxtName.Text = DtgvContacts.CurrentRow.Cells[1].Value.ToString();
                frm.TxtLastName.Text = DtgvContacts.CurrentRow.Cells[2].Value.ToString();
                frm.TxtAdress.Text = DtgvContacts.CurrentRow.Cells[3].Value.ToString();
                frm.MTxtPersonalPhone.Text = DtgvContacts.CurrentRow.Cells[4].Value.ToString();
                frm.MTxtWorkPhone.Text = DtgvContacts.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
                FillDgv();
            }
            else
            {
                FrmNotify frm = new FrmNotify($"Oops, selecciona un contacto!");
                frm.ShowDialog();
            }
        }

        private void AddContact()
        {
            FrmAddContact frm = new FrmAddContact();
            frm.Edit = false;
            frm.IdLogged = IdLogged;

            frm.ShowDialog();
            FillDgv();
        }

        private void DeleteContact()
        {
            if (DtgvContacts.SelectedRows.Count > 0)
            {
                int IdContact = Convert.ToInt32(DtgvContacts.CurrentRow.Cells[0].Value.ToString());

                FrmQuestion question = new FrmQuestion($"¿Estas seguro que desea eliminar a el contacto {DtgvContacts.CurrentRow.Cells[1].Value}?");

                DialogResult result = question.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool response = _service.DeleteContact(IdContact);
                    if (response)
                    {
                        FrmNotify frm = new FrmNotify($"Este contacto ha sido eliminado con exito en ContactAppBook, por favor utilize la app sabiamente para evitar inconvenientes.");
                        frm.PnInit.BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(111)))));
                        frm.BtnContinue.ForeColor = Color.FromArgb(0, 37, 211, 111);
                        frm.ShowDialog();
                    }
                    else
                    {
                        FrmNotify frm = new FrmNotify($"Oops, ha ocurrido un error!");
                        frm.ShowDialog();
                    }
                }

            }
            else
            {
                FrmNotify frm = new FrmNotify($"Oops, selecciona un contacto!");
                frm.ShowDialog();
            }
        }

        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }


}
