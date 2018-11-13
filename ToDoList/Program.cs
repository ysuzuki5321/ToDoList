using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ToDoList
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new DbInitializer());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TodoForm(new TodoDataRepository()));

        }
    }
}
