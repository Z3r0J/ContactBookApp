using BusinessLayer;
using DataLayer.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ContactBookApp
{
    public partial class FrmLogin : Form
    {
        #region DLLFORTHEBAR

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        #endregion

        private ServiceUsers _Users;
        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _Users = new ServiceUsers(connection);
        }

        #region Events
        private void Btn_Login_Click(object sender, System.EventArgs e)
        {
                if (IsLoggin())
                {

                }
                else
                {
                    FrmNotify frm = new FrmNotify($"Oops, su usuario no existe!");
                    frm.ShowDialog();

                }
        }
        private void PnInit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Methods

        public bool IsLoggin()
        {

            bool Log;
            string UserName = Txt_Username.Text;
            string Password = Txt_Password.Text;

            Users IsLogin = _Users.S_LoginUsers(UserName, Password);
            if (IsLogin != null)
            {
                Log = true;

                FrmNotify frm = new FrmNotify($"Bienvenido a ContactBookApp {IsLogin.Name} {IsLogin.LastName}, todo los movimientos se registran por favor utilizala con prudencia.");
                frm.PnInit.BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(111)))));
                frm.BtnContinue.ForeColor = Color.FromArgb(0, 37, 211, 111);
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                Log = false;
            }
            return Log;
        }

        #endregion
    }
}
