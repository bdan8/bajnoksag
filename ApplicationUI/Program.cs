using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TournamentTracker.GlobalConfig.InitializeConnections(TournamentTracker.DatabaseType.Sql);
            Application.Run(new TournamentDashboardForm());
        }
    }
}
