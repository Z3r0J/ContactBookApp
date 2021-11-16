using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactBookApp
{
    public partial class FrmNotify : Form
    {
        public FrmNotify(string mensaje)
        {
            InitializeComponent();

            LblMensaje.Text = mensaje;
        }
    }
}
