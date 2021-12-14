using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDAL
{
    public class Major
    {
        /// <summary>
        /// 查询学校
        /// </summary>
        /// <returns></returns>
        public List<string> GetSchoolName()
        {
            //生成SQL命令
            List<string> columnName = new List<string>();
            string sql = "select name from syscolumns where id=object_id('tb_Major')";
            using (SqlDataReader dr = Helper.ExecuteReader(sql))
            {
                while (dr.Read())
                {
                    columnName.Add(dr[0].ToString());
                }
                dr.Close();
                return columnName;
            }
        }

        /// <summary>
        /// 查询该学校的专业
        /// </summary>
        /// <param name="SchoolName"></param>
        /// <returns></returns>
        public List<string> GetMajor(string SchoolName)
        {
            //生成SQL命令
            List<string> Major=new List<string>();
            string sql = "select " + SchoolName + " from [tb_Major]";
            using (SqlDataReader dr = Helper.ExecuteReader(sql))
            {
                while (dr.Read())
                {
                    Major.Add(dr[0].ToString());
                }
                dr.Close ();
                return Major;
            }
        }
    }
}
