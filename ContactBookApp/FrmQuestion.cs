using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactBookApp
{
    public partial class FrmQuestion : Form
    {
        public FrmQuestion(string mensaje)
        {
            InitializeComponent();

            LblMensaje.Text = mensaje;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
