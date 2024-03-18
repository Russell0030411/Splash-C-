using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura.GUI
{
    public partial class Login : Form
    {
        //Atributos
        private Boolean _Autorizado = false;
        //Ctrl + R + E
        public bool Autorizado { get => _Autorizado; }


        String _Usuario = "Juan";
        String _Clave = "123";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbUser.Text.Equals(_Usuario) && mtxtbPassword.Text.Equals(_Clave))
            {
                _Autorizado = true;
                Close();
            }
            else
            {
                lblMensaje.Text = "Verifique su usuario o clave, no son los correctos ";
                _Autorizado = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
