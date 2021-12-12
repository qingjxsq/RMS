using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SQLDAL;

namespace BLL
{
    public class SchoolBLL
    {
        //创建学校数据库访问对象
        SchoolDAL dalSchool=new SchoolDAL();

        ///<summary>
        ///读取学校
        /// </summary>
        public List<School> GetSchools()
        {
            return dalSchool.GetSchools();
        }

        ///<summary>
        ///修改专业
        /// </summary>
        /// <param name="school"></param>
        /// <returns></returns>
        public int UpdateMajor(School school)
        {
            return dalSchool.UpdateMajor(school);
        }


        ///<summary>
        ///添加学校
        /// </summary>
        /// <param name="school"></param>
        /// <returns></returns>
        public int AddSchool(School school)
        {
            return dalSchool.AddSchool(school);
        }
    }
}
