using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace From
{
    public partial class QueryFrom : Form
    {
        ResumeBLL bllResume=new ResumeBLL();
        public QueryFrom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// "查询"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //获取查询条件
            string con=this.cmbQuery.Text.ToString().Trim();
            string value=this.txtQuery.Text.Trim();
            string strWhere = "";
            if (con.Equals("身份证号"))
                strWhere = "ID like '%" + value + "%'";
            if (con.Equals("姓名"))
            {
                strWhere = "Name like '%" + value + "%'";
            }
            if (con.Equals("学校"))
                strWhere = "School like'%" + value + "%'";
            if (con.Equals("专业"))
                strWhere = "Major like '%" + value + "%'";
            this.dataGridView1.DataSource=bllResume.GetResumeList(strWhere);
        }

        /// <summary>
        /// "关闭"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
