using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using System.IO;

namespace From
{
    public partial class EditFrom : Form
    {
        //定义变量
        string oldFileName = "";
        string photoName = "";
        ResumeBLL bllResume=new ResumeBLL();
        MajorBLL bllMajor=new MajorBLL();
        bool flag=false;
        Resume resume = new Resume();
        #region Method
        public EditFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// "查询"按钮事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //获取输入
            string id=this.txbSerchID.Text.Trim();
            //查询简历信息
            resume=bllResume.GetResumeByID(id);
            //显示简历信息
            this.txbID.Text=resume.ID;
            this.txbName.Text=resume.Name;
            if (resume.Gender == "男")
            {
                this.rbMen.Checked=true;
            }
            else
            {
                this.radioButton2.Checked=true;
            }
            this.cbPolitSta.Text = resume.PoliSta;
            this.cbSchool.Text = resume.School;
            this.cbMajor.Text = resume.Major;
            this.txtBirthDay.Text = resume.Birthday;
            photoName = resume.Photoes;
            string phoPath = Path.Combine(Application.StartupPath, "Images");
            string photo=Path.Combine(phoPath,photoName);
            Stream s = File.Open(photo, FileMode.Open);
            this.pictureBox1.Image = Image.FromStream(s);
            s.Close();
        }

        /// <summary>
        /// “清除”按钮事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txbSerchID.Text = "";
            this.txbSerchID.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditFrom_Load(object sender, EventArgs e)
        {
            
            this.cbSchool.DataSource = bllMajor.GetSchool();
        }

        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbSchool.SelectedItem != null)
            {
                
                this.cbMajor.DataSource = bllMajor.GetMajor(this.cbSchool.Text);
            }
        }

        /// <summary>
        /// "选择照片"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSeletPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件(*.*)|*.*|jpg图片(*.jpg)|*.jpg|PNG图片(*.png)|*.png";
            ofd.Title = "选择图片";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Image = Image.FromFile(oldFileName);
                oldFileName = ofd.FileName;
                flag = true;
            }
        }

        /// <summary>
        /// "更新"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //提示对话框
            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            
            if (result == DialogResult.Yes)
            {
                
                //更改赋值
                resume.ID=this.txbID.Text.Trim();
                resume.Name=this.txbName.Text.Trim();
                resume.Gender = this.rbMen.Checked ? "男" : "女";
                resume.PoliSta = this.cbPolitSta.Text;
                resume.Birthday=this.txtBirthDay.Text;
                resume.School=this.cbSchool.SelectedValue.ToString().Trim();
                resume.Major = this.cbMajor.SelectedValue.ToString().Trim();
                if (flag == true)
                {
                    string fileType=Path.GetFileName(oldFileName);
                    string photo = this.txbID.Text.Trim() + fileType;
                    string photoPath = Path.Combine(Application.StartupPath, "Images");
                    //判断文件夹是否存在
                    if(!Directory.Exists(photoPath))
                        Directory.CreateDirectory(photoPath);
                    string newFileName=Path.Combine(photoPath,photo);
                    //复制文件到指定文件夹
                    File.Copy(oldFileName,newFileName);
                    resume.Photoes = photo;
                }
                else
                {
                    resume.Photoes = photoName;
                }
                //生成简历管理对象
                ResumeBLL bllresume=new ResumeBLL();
                //调用业务逻辑层的方法
                if (bllResume.UpdateResume(resume) > 0)
                {
                    MessageBox.Show("修改学生成绩成功", "提示");
                }
                else
                    MessageBox.Show("修改学生信息失败", "提示");
            }
        }


        /// <summary>
        /// "删除"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //用户选择确定
            if(result == DialogResult.Yes)
            {
                //
                ResumeBLL bllRrsume=new ResumeBLL();
                //调用业务逻辑层方法
                if (bllResume.DeleltResume(this.txbID.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除学生成功", "提示");

                }
                else
                {
                    MessageBox.Show("删除学生失败", "提示");
                }
            }
        }

        /// <summary>
        /// "退出"按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Method
    }
}
