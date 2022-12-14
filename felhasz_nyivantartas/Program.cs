using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace felhasz_nyivantartas
{
    internal static class Program
    {
        static public Form_nyito Form_Open = null;
        static public form_delete form_Delete = null;
        static public form_edit form_Edit = null;
        static public form_add form_New = null;
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Open = new Form_nyito();
            form_Delete = new form_delete();
            form_Edit = new form_edit();
            form_New = new form_add();
            Application.Run(Form_Open);
        }
    }
}
