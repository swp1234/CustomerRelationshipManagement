using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CustomerRelationshipManagement
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            SQLiteConnection.CreateFile("./b.sqlite");
            SQLiteConnection conn = new SQLiteConnection("Data Source=./b.sqlite;Version=3;");
            conn.Open();
        }
    }
}
