using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ContactBookApp
{
    public partial class FrmAddContact : Form
    {
        public char BlackAndLight { get; set; } = 'L';
        public bool Edit { get; set; }

        public int IdLogged { get; set; }
        public int IdContact { get; set; }

        ServiceContact _service;
        Contacts contacts;
        public FrmAddContact()
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
        private void BtnLightAndDarkTheme_Click(object sender, EventArgs e)
        {
           
            if (BlackAndLight=='L')
            {
                BlackAndLight = 'B';
                this.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
                this.ForeColor = Color.White;
                BtnLightAndDarkTheme.Text = "Dark Theme 🌑";
                BtnLightAndDarkTheme.ForeColor = Color.White;

                TxtName.BackColor = Color.White;
                TxtName.ForeColor = Color.Black;

                TxtLastName.BackColor = Color.White;
                TxtLastName.ForeColor = Color.Black;

                PbxTheme.Image = Properties.Resources.theme_black;
                PbxName.Image = Properties.Resources.name_black;
                PbxLastName.Image = Properties.Resources.name_black;
                PbxAdress.Image = Properties.Resources.adress_black;
                PbxPersonal.Image = Properties.Resources.personal_black;
                PbxWork.Image = Properties.Resources.work_black;

                BtnSaveContact.Image = Properties.Resources.save_black;
                pictureBox1.Image = Properties.Resources.close_dark;

            }
            else
            {
                BlackAndLight = 'L';
                this.BackColor = Color.White;
                BtnLightAndDarkTheme.Text = "Light Theme ☀";
                this.ForeColor = Color.Black;
                BtnLightAndDarkTheme.ForeColor = Color.Black;

                TxtName.BackColor = Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
                TxtName.ForeColor = Color.White;

                TxtLastName.BackColor = Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
                TxtLastName.ForeColor = Color.White;

                PbxTheme.Image = Properties.Resources.theme_white;
                PbxName.Image = Properties.Resources.name_white;
                PbxLastName.Image = Properties.Resources.name_white;
                pictureBox1.Image = Properties.Resources.close32;

                PbxAdress.Image = Properties.Resources.adress_white;
                PbxPersonal.Image = Properties.Resources.personal_white;
                PbxWork.Image = Properties.Resources.work_white;

                BtnSaveContact.Image = Properties.Resources.save_white;
            }
        }

        private void BtnSaveContact_Click(object sender, EventArgs e)
        {
            ValidatingInsertData();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
#endregion
        #region Methods

        public void ValidatingInsertData()
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                FrmNotify frm = new FrmNotify($"Oops, Insert a Name!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtLastName.Text))
            {
                FrmNotify frm = new FrmNotify($"Oops, Insert a LastName!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtAdress.Text))
            {
               FrmNotify frm = new FrmNotify($"Oops, Insert a Adress!");
                frm.ShowDialog();
            }
            else if (MTxtPersonalPhone.MaskCompleted==false)
            {
                FrmNotify frm = new FrmNotify($"Oops, Insert a Personal Phone!");
                frm.ShowDialog();
            }
            else if (MTxtWorkPhone.MaskCompleted==false)
            {
                FrmNotify frm = new FrmNotify($"Oops, Insert a Work Phone!");
                frm.ShowDialog();
            }

            else
            {
                if (Edit)
                {
                    if (IsEdit())
                    {
                        FrmNotify frm = new FrmNotify($"Este contacto ha sido editado con exito en ContactAppBook, por favor utilize la app sabiamente para evitar inconvenientes.");
                        frm.PnInit.BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(111)))));
                        frm.BtnContinue.ForeColor = Color.FromArgb(0, 37, 211, 111);
                        frm.ShowDialog();
                        ClearAll();
                        this.Close();
                    }
                    else
                    {
                        FrmNotify frm = new FrmNotify($"Oops, ha ocurrido un error!");
                        frm.ShowDialog();
                    }
                }
                else
                {
                    if (IsAdd())
                    {
                        FrmNotify frm = new FrmNotify($"Este contacto ha sido agregado con exito en ContactAppBook, por favor utilize la app sabiamente para evitar inconvenientes.");
                        frm.PnInit.BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(111)))));
                        frm.BtnContinue.ForeColor = Color.FromArgb(0, 37, 211, 111);
                        frm.ShowDialog();
                        ClearAll();
                        this.Close();
                    }
                    else
                    {
                        FrmNotify frm = new FrmNotify($"Oops, ha ocurrido un error!");
                        frm.ShowDialog();
                    }
                }
            }
        }


        public bool IsEdit()
        {
            contacts = new Contacts() {
                ContactName = TxtName.Text,
                LastName = TxtLastName.Text,
                Adress = TxtAdress.Text,
                PersonalPhone = MTxtPersonalPhone.Text,
                WorkPhone = MTxtWorkPhone.Text,
                IdUser=IdLogged
            };

            bool ret = _service.EditContact(contacts,IdContact);

            return ret;
        }

        public bool IsAdd()
        {
            contacts = new Contacts()
            {
                ContactName = TxtName.Text,
                LastName = TxtLastName.Text,
                Adress=TxtAdress.Text,
                PersonalPhone = MTxtPersonalPhone.Text,
                WorkPhone = MTxtWorkPhone.Text,
                IdUser = IdLogged
            };
            bool ret = _service.AddContact(contacts);

            return ret;
        }
        public void ClearAll()
        {
            TxtName.Clear();
            TxtLastName.Clear();
            TxtAdress.Clear();
            MTxtPersonalPhone.Clear();
            MTxtWorkPhone.Clear();
            TxtName.Focus();
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
