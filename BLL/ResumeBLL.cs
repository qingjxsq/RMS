using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLDAL;
namespace BLL
{
    public class ResumeBLL
    {
        //创建简历数据访问对象
        ResumeDAL dalResume=new ResumeDAL();
        ///<summary>
        ///添加学生
        /// </summary>
        /// <param name="resume"></param>
        ///<return></return>
        public int AddResume(Model.Resume resume)
        {
            return dalResume.AddResume(resume); 
        }

        ///<summary>
        ///查询简历
        /// </summary>
        /// <param name="id"></param>
        /// <return></return>
        public Model.Resume GetResumeByID(string id)
        {
            return dalResume.GetResumeID(id);
        }

        ///<summary>
        ///修改简历
        /// </summary>
        /// <param name="resume"></param>
        /// <return></return>
        public int UpdateResume(Model.Resume resume)
        {
            return dalResume.UpdateResume(resume);
        }

        ///<summary>
        ///删除简历
        /// </summary>
        /// <param name="id"></param>
        /// <return></return>
        public int DeleltResume(string id)
        {
            return dalResume.DeleteResume(id);
        }

        ///<summary>
        ///根据查询条件返回简历信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <return></return>
        public DataTable GetResumeList(string strWhere)
        {
            return dalResume.GetRrsumeList(strWhere);
        }
    }
}
