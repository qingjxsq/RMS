using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDAL
{
    public class SchoolDAL
    {
        ///<summary>
        ///修改学校专业,因为专业以字符串形式存储，以修改专业字符串实现添加专业
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public int UpdateMajor(Model.School school)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("UPDATE [dbo.tb_School] SET ");
            strSQL.Append("SchoolName=@Schoolname,Major=@MajorWHERE SchoolName=@SchoolName");
            SqlParameter[] parameters = new SqlParameter[] {new SqlParameter("@SchoolName",school.Name),new SqlParameter("@Major",school.Major)};
            return Helper.ExecuteNonQuery(strSQL.ToString(),CommandType.Text,parameters);
        }
        ///<summary>
        ///添加学校
        /// </summary>
        /// <param name="school"></param>
        /// <returns></returns>
        public int AddSchool(Model.School school)
        {
            //生成SQL命令
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("INSERT INTO [dbo.tb_School] (SchoolName,Major)");
            strSQL.Append("VALUES(@SchoolName,@Major)");
            //生成参数数组
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@SchoolName", school.Name), new SqlParameter("@Major", school.Major) };
            //执行Helper命令
            return Helper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text,parameters);
        }
        ///<summary>
        ///加载学校,用于添加时选择
        /// </summary>
        /// <returns>
        /// List<Model.School>
        /// </returns>
        public List<Model.School> GetSchools ()
        {
            List<Model.School> schools = new List<Model.School>();
            Model.School school = new Model.School();
            //构造SQL语句
            string strSQL= "SELECT * FROM [dbo.tb_School]" ;
            using(SqlDataReader dr = Helper.ExecuteReader(strSQL))
            {

                while (dr.HasRows)
                {
                    dr.Read();
                    school.Name = dr["SchoolName"].ToString().Trim();
                    school.Major = dr["Major"].ToString().Trim();
                    school.MajorToArr();
                    schools.Add(school);
                }
            }
            return schools;
        }
    }
}
