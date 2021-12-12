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
    public partial class Loginfrom : Form
    {
        public Boolean flag=false;
        public Loginfrom()
        {
            InitializeComponent();
        }

        private void wecome_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }
    }
}
