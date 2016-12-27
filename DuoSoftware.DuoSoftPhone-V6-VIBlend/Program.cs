using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using DuoSoftware.DuoTools.DuoLogger;

namespace DuoSoftware.DuoSoftPhone
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (s, e) =>
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "Main - Lost Network Or Unhandled Exception ThreadException", e.Exception, Logger.LogLevel.Error);
                MessageBox.Show("Main - Lost Network Or Unhandled Exception", "Duo Dialer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            };
            AppDomain.CurrentDomain.UnhandledException+= (s, e) =>
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "Main - Lost Network Or Unhandled Exception UnhandledException",(Exception) e.ExceptionObject, Logger.LogLevel.Error);
                MessageBox.Show("Main - Lost Network Or Unhandled Exception", "Duo Dialer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            };
            new Ui.Login().ShowDialog();

        }

        
    }
}
