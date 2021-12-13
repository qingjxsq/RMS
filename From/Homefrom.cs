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
    public partial class HomeFrom : Form
    {
        public HomeFrom()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("写了但是没有完全写", "帮助");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeshower.Text = DateTime.Now.ToString();
        }

        private void HomeFrom_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            timeshower.Text = DateTime.Now.ToString();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("写了但是没有完全写", "帮助");
        }

        private void AddResume_Click(object sender, EventArgs e)
        {
            Addfrom addfrom=new Addfrom();
            addfrom.ShowDialog();
        }

        private void DeleteResume_Click(object sender, EventArgs e)
        {
            EditFrom editFrom=new EditFrom();
            editFrom.btnUpdate.Enabled = false;
            editFrom.ShowDialog();
        }

        private void UpdateResume_Click(object sender, EventArgs e)
        {
            EditFrom editFrom =new EditFrom();
            editFrom.btnDelete.Enabled = false;
            editFrom.ShowDialog();
        }
    }
}
