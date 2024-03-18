using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura.CLS
{
    internal class AppManager : ApplicationContext
    {
        private void SplashScreen()
        {
            try
            {
                GUI.Splash f = new GUI.Splash();
                f.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private Boolean LoginScreen()
        {
            Boolean Resultado = false;
            try
            {
                GUI.Login f = new GUI.Login();
                f.ShowDialog();
                Resultado = f.Autorizado;

            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;

        }


        public AppManager()
        {
            SplashScreen();
            if (LoginScreen())
            {
                GUI.Principal f = new GUI.Principal();
                f.ShowDialog();
            }
            else
            {  
            }
        }


    }
}
