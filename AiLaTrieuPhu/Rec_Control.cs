using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu
{
    class Rec_Control
    {
        public System.Drawing.Rectangle rec;
        public System.Windows.Forms.Control ctrl;
        
        public Rec_Control(System.Drawing.Rectangle rec, System.Windows.Forms.Control ctrl)
        {
            this.rec = rec;
            this.ctrl = ctrl;
        }

    }
}
