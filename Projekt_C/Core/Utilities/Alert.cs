using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_C.Core.Utilities
{
    static class Alert
    {
        internal static void IdTaken()
        {
            MessageBox.Show("An item with the given id already exists.");
        }
    }
}
