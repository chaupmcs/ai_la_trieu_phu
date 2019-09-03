using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    class NoFlickeringPanel: Panel
    {
            public NoFlickeringPanel()
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.UserPaint, true);
            }
    }
}
