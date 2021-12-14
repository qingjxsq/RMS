using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace From
{
    public partial class Addfrom : Form
    {
        string oldFilename =string .Empty;
        List<string> lstSchool=new List<string>();
        MajorBLL bllMajor=new MajorBLL();

        /// <summary>
        /// 加载学校
        /// </summary>

        private void AddSchool()
        {
            
            lstSchool = bllMajor.GetSchool();
            this.cbSchool.DataSource = bllMajor.GetSchool();

        }
        public Addfrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件(*.*)|*.*|jpg图片(*.jpg)|*.jpg|PNG图片(*.png)|*.png";
            ofd.Title = "选择图片";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                oldFilename = ofd.FileName;
                pictureBox1.Image = Image.FromFile(oldFilename);

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private string GetHobby()
        {
            string hobby = " ";
            if(this.checkBox1.Checked == true)
            {
                hobby += this.checkBox1.Text +" ";
            }
            if (this.checkBox2.Checked == true)
            {
                hobby += this.checkBox2.Text + " ";
            }
            if (this.checkBox3.Checked == true)
            {
                hobby += this.checkBox3.Text + " ";
            }
            if (this.checkBox4.Checked == true)
            {
                hobby += this.checkBox4.Text + " ";
            }
            return hobby;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id =this.txtID.Text;
            string name =this.txtName.Text;
            string gender = this.radioButton1.Checked ? "男" : "女";
            string poliyi = this.comboBox1.Text;
            string birthday = this.dTBrithday.Value.ToString("yyyy-mm-dd");
            string School =this.cbSchool.Text.Trim();
            string major =this.cbMajor.Text.Trim();
            string fileType =Path.GetExtension(oldFilename);
            string photo = id + fileType;
            string spec = this.GetHobby();
            string imgPath =Path.Combine(Application.StartupPath,"Images");
            //判断文件夹是否存在
            if (!Directory.Exists(imgPath))
            
                Directory.CreateDirectory(imgPath);
            string newFileName =Path.Combine(imgPath,photo);
            //复制文件到指定文件夹
            File.Copy(oldFilename,newFileName,true);

            //建立简历实体
            Resume resume = new Resume();
            resume.ID = id;
            resume.Name = name;
            resume.Gender = gender;
            resume.Birthday = birthday;
            resume.School = School;
            resume.Major = major;
            resume.PoliSta = poliyi;
            resume.Photoes = photo;
            resume.Speciality = spec;
            
            //建立建立业务逻辑层对象
            ResumeBLL resumeBLL = new ResumeBLL();

            if (resumeBLL.AddResume(resume) > 0)
            {
                MessageBox.Show("添加简历成功", "添加简历");
            }
            else
            {
                MessageBox.Show("添加简历失败", "添加简历");
            }
        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 当院系发生改变事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            if (this.cbSchool.SelectedItem !=null)
            {
                
                this.cbMajor.DataSource = bllMajor.GetMajor(this.cbSchool.Text);
            }
            else
            {
                MessageBox.Show("没有选择学校！", "提示");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addfrom_Load(object sender, EventArgs e)
        {
            lstSchool = bllMajor.GetSchool();
            this.cbSchool.DataSource = bllMajor.GetSchool();
        }
    }
}
