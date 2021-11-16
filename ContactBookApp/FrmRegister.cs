﻿using BusinessLayer;
using DataLayer.Models;
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

        private void BtnLightAndDarkTheme_Click(object sender, EventArgs e)
        {
           
            if (BlackAndLight=='L')
            {
                BlackAndLight = 'B';
                this.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
                this.ForeColor = Color.White;
                BtnLightAndDarkTheme.Text = "Dark Theme 🌑";
                BtnLightAndDarkTheme.ForeColor = Color.White;
            }
            else
            {
                BlackAndLight = 'L';
                this.BackColor = Color.White;
                BtnLightAndDarkTheme.Text = "Light Theme ☀";
                this.ForeColor = Color.Black;
                BtnLightAndDarkTheme.ForeColor = Color.Black;
            }
        }

        private void BtnRegistrarte_Click(object sender, EventArgs e)
        {
            ValidatingInsertData();
        }


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
                    FrmNotify frm = new FrmNotify($"Usted {TxtName.Text} ha sido registrado con exito a ContactAppBook, por favor utilize la app sabiamente para evitar inconveniente.");
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