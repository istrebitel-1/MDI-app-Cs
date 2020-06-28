using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIproject
{
    public partial class Goose : Form
    {
        public Goose()
        {
            InitializeComponent();
            
        }
        private void PlaySong(object sender, EventArgs e)
        {
            close.BackColor = Color.Gray;
            close.Enabled = false;
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
           
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(415, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);

            Console.Beep(523, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(440, 120);
            close.Enabled = true;
            close.BackColor = Color.DarkRed;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
