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
    public partial class FrmRegister : Form
    {
        public char BlackAndLight { get; set; } = 'L';

        ServiceUsers _service;
        Users users;
        public FrmRegister()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            SqlConnection _connection = new SqlConnection(connectionString);
            _service = new ServiceUsers(_connection);
            users = new Users();
            
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

                TxtPassword.BackColor = Color.White;
                TxtPassword.ForeColor = Color.Black;

                TxtConfirmPassword.BackColor = Color.White;
                TxtConfirmPassword.ForeColor = Color.Black;

                TxtUsername.BackColor = Color.White;
                TxtUsername.ForeColor = Color.Black;

                PbxTheme.Image = Properties.Resources.theme_black;
                PbxName.Image = Properties.Resources.name_black;
                PbxUserName.Image = Properties.Resources.username_black;
                PbxLastName.Image = Properties.Resources.name_black;
                PbxPassword.Image = Properties.Resources.password_dark;
                PbxConfirmPassword.Image = Properties.Resources.password_dark;
                pictureBox1.Image = Properties.Resources.close_dark;

                BtnRegistrarte.Image = Properties.Resources.save_black;

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

                TxtPassword.BackColor = Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
                TxtPassword.ForeColor = Color.White;

                TxtConfirmPassword.BackColor = Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
                TxtConfirmPassword.ForeColor = Color.White;

                TxtUsername.BackColor = Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
                TxtUsername.ForeColor = Color.White;

                PbxTheme.Image = Properties.Resources.theme_white;
                PbxName.Image = Properties.Resources.name_white;
                PbxUserName.Image = Properties.Resources.username_white;
                PbxLastName.Image = Properties.Resources.name_white;
                PbxPassword.Image = Properties.Resources.password_white;
                PbxConfirmPassword.Image = Properties.Resources.password_white;
                pictureBox1.Image = Properties.Resources.close32;

                BtnRegistrarte.Image = Properties.Resources.save_white;
            }
        }

        private void BtnRegistrarte_Click(object sender, EventArgs e)
        {
            ValidatingInsertData();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                FrmNotify frm = new FrmNotify($"Oops, inserte un nombre!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtLastName.Text))
            {
                FrmNotify frm = new FrmNotify($"Oops, inserte un nombre!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
               FrmNotify frm = new FrmNotify($"Oops, inserte un nombre de usuario!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                FrmNotify frm = new FrmNotify($"Oops, inserte una contraseña!");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
            {
                FrmNotify frm = new FrmNotify($"Oops, confirme su contraseña");
                frm.ShowDialog();
            }
            else if (TxtConfirmPassword.Text != TxtPassword.Text)
            {
                FrmNotify frm = new FrmNotify($"Oops, la contraseña no coincide con la insertada");
                frm.ShowDialog();
            }

            else if (ExistTheUser())
            {
                FrmNotify frm = new FrmNotify($"Oops, el  nombre de usuario existe actualmente");
                frm.ShowDialog();
            }
            else
            {
                if (IsRegister())
                {
                    FrmNotify frm = new FrmNotify($"Usted {TxtName.Text} ha sido registrado con exito a ContactAppBook, por favor utilize la app sabiamente para evitar inconvenientes.");
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


        public bool IsRegister()
        {

            users.Name = TxtName.Text;
            users.LastName = TxtLastName.Text;
            users.UserName = TxtUsername.Text;
            users.Password = TxtPassword.Text;
     
            bool Reg = _service.S_RegisterUsers(users);
           
            return Reg;
        }


        public bool ExistTheUser()
        {
            Users users = _service.ValidateExistUser(TxtUsername.Text);

            if (users!=null)
            {
                return true;
            }
        

            return false;
        }

        #endregion

    }
}
