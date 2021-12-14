using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLDAL;

namespace BLL
{
    public class MajorBLL
    {
        Major major=new Major();

        /// <summary>
        /// 加载学校
        /// </summary>
        /// <returns></returns>
        public List<string> GetSchool()
        {
            return major.GetSchoolName();
        }

        /// <summary>
        /// 返回学校专业
        /// </summary>
        /// <param name="SchoolName"></param>
        /// <returns></returns>
        public List<string> GetMajor(string SchoolName)
        {
            return major.GetMajor(SchoolName);
        }
    }
}
