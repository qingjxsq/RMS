using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From
{
    public partial class Homefrom : Form
    {
        public Homefrom()
        {
            InitializeComponent();
        }

        private void Homefrom_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            timeshower.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeshower.Text=DateTime.Now.ToString();
        }
    }
}
