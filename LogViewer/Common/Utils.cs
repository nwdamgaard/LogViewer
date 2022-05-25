using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer
{
    internal class Utils
    {
        public const string LogIndex = "logIndex";

        public static void userError(string message)
        {
            MessageBox.Show(message, "Error");
        }
    }
}
