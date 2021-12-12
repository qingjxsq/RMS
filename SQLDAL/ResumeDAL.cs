using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace SQLDAL
{
    public class ResumeDAL
    {
        ///<summary>
        ///添加简历信息
        ///</summary>
        ///<param name="resume"></param>
        ///<returns></returns>
        public int AddResume(Model.Resume resume)
        {
            //生成SQl命令
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("INSERT INTO [dbo.tb_Resume](ID,Name,Gender,PoliticaStatus," +
                            "Birthday,School,Major,Speciality,Photoes)");
            strSQL.Append("VALUSE(@ID,@Name,@Gender,@PoliticaStatus," +
                            "@Birthday,@School,@Major,@Speciality,@Photoes)");
            //生成参数数组
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID",resume.ID),
                new SqlParameter("@Name",resume.Name),
                new SqlParameter("@Gender",resume.Gender),
                new SqlParameter("@Politicalstatus",resume.PoliSta),
                new SqlParameter("@Birthday",resume.Birthday),
                new SqlParameter("@School",resume.School),
                new SqlParameter("@Major",resume.Major),
                new SqlParameter("@Speciality",resume.Speciality),
                new SqlParameter("@Photoes",resume.Photoes),
            };
            //执行Hepler命令
            return Helper.ExecuteNonQuery(strSQL.ToString(),CommandType.Text,parameters);
        }
        ///<summary>
        ///删除简历
        ///</summary>
        ///<param name="id"></param>
        ///<returns></returns>
        public int DeleteResume(string id)
        {
            string strSQL = string.Format("DELETE FROM [dbo.tb_Resume] WHERE ID=@ID");
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@ID",id) };
            return Helper.ExecuteNonQuery(strSQL.ToString(),CommandType.Text,parameter);
        }
        ///<summary>
        ///修改简历
        /// </summary>
        /// <param name="resumne"></param>
        /// <returns></returns>
        public int UpdateResume(Model.Resume resume)
        {
            //构造SQL语句
            StringBuilder strSQL= new StringBuilder();
            strSQL.Append("UPDATE [dbo.tb_Resume] SET  ");
            strSQL.Append("" +
                "Name=@Name," +
                "Gender=@Gender," +
                "Politicalstaus=@Politicalstaus," +
                "Birthday=@Birthday,"+
                "School=@School," +
                "Major=@Major" +
                "Speciality=@Speciality" +
                "Photoes=@Photoes" +
                "WHERE ID=@ID");
            //参数数组
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID",resume.ID),
                new SqlParameter("@Name",resume.Name),
                new SqlParameter("@Gender",resume.Gender),
                new SqlParameter("@Politicalstatus",resume.PoliSta),
                new SqlParameter("@Birthday",resume.Birthday),
                new SqlParameter("@School",resume.School),
                new SqlParameter("@Major",resume.Major),
                new SqlParameter("@Speciality",resume.Speciality),
                new SqlParameter("@Photoes",resume.Photoes),
            };
            //执行SQL语句
            return Helper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text,parameters);
        }
        ///<summary>
        ///根据身份证号码查询人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Resume GetResumeID(string id)
        {
            Model.Resume resume = new Model.Resume();
            //构造SQL语句
            string strSQL = "SELECT * FROM [dbo.tb_Resume] WHERE ID=@ID";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@ID", id) };
            //返回结果集
            using (SqlDataReader dr = Helper.ExecuteReader(strSQL, CommandType.Text, para))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    //读取数据
                    resume.ID = dr["ID"].ToString().Trim();
                    resume.Name = dr["Name"].ToString().Trim();
                    resume.Gender = dr["Gender"].ToString().Trim();
                    resume.PoliSta = dr["Politicalstatus"].ToString().Trim();
                    resume.Birthday = dr["Birthday"].ToString().Trim();
                    resume.School = dr["School"].ToString().Trim();
                    resume.Major = dr["Major"].ToString().Trim();
                    resume.Speciality = dr["Speciality"].ToString().Trim();
                    resume.Photoes = dr["Photoes"].ToString().Trim();

                }
                return resume;
            }
        }
        ///<summary>
        ///根据查询条件，获取简历列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetRrsumeList(string strWhere)
        {
            //生成SQL命令
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT ID,Name,Gender,PoliticaStatus," +
                            "Birthday,School,Major,Speciality,Photoes from[dbo.tb_Resume]");
            if(strWhere != null)
            {
                strSQL.Append(" and " + strWhere);
            }
            return Helper.ExecuteDataTable(strSQL.ToString());
        }

    }
}
