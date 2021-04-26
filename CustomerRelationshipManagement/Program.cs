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
            Application.Run(new MainForm());
            //SQLiteConnection conn = new SQLiteConnection("Data Source=E:/project/CustomerRelationshipManagement/CustomerRelationshipManagement/memberdatabase.db;Version=3;");
            //conn.Open();
            //string sql = "select * from member";
            //SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            //var reader = cmd.ExecuteScalar();

        }
    }
}
