using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmUser());
           // Application.Run(new frmCustomerUpdate());
            //Application.Run(new frmCustomer());
           // Application.Run(new frmRoom());
           // Application.Run(new frmBookingRoom());
          //  Application.Run(new frmLaundryItem());
           // Application.Run(new frmLaundry());
           // Application.Run(new frmReceptionMenu());
           // Application.Run(new frmAdminMenu());
           // Application.Run(new frmReceptionVarification());
            Application.Run(new frmMainMenu());
         //   Application.Run(new frmRecipes());

        }
    }
}
