using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    internal class ball
    {
        public System.Windows.Forms.Label Ball { get; set; }
        public int BallSpeed
        {
            get { return speedLv; }
            set
            {
                speedLv = value;
                time = 50 - 5 * speedLv;
            }
            
        }
        public int time { get; set; }
        public int speedLv { get; set; }
         

    }
}
