using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableT
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelload.Width += 6;
            if (panelload.Width >= 800)
            {
                timer1.Stop();
                Home frm = new Home();
                frm.Show();
                this.Hide();
            }
        }
    }
}
