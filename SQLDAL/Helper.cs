using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SQLDAL
{
    /// <summary>
    /// 针对数据库操作的通用类
    /// Version:1.0
    /// </summary>
    public class Helper
    {
        private static string connString=
            ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString.ToString();
        /// <summary>
        /// 设置数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }
        ///<summary>
        ///执行一个查询结果，并返回查询结果
        ///</summary>
        ///<param name="commandText">要执行的SQl语句</param>
        ///<param name="comandType">要执行是查询语句类型，如存储过程或者SQl文本命令</param>
        ///<param nmae="paramenter">Transact-语句或者存储过程的参数数组</param>
        ///<return></return>
        public static DataTable ExecuteDataTable(string commandText,CommandType commandType,SqlParameter[] parameters)
        {
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //设置cmd的CommandType为指定的CommandType
                    cmd.CommandType = commandType;
                    if(parameters != null)
                    {
                        foreach (SqlParameter paramter in parameters)
                        {
                            cmd.Parameters.Add(paramter);
                        }
                    }
                    //通过包含查询SQl的SqlComand实例来实例化SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);//填充DataTable
                }
            }
            return ds.Tables[0];
        }
        ///<summary>
        ///执行一个查询，并返回查询结果
        ///</summary>
        ///<param name="commanText">要执行的SQL语句</param>
        ///<param name="commanType">要执行的查询语句的类型，如果存储过程或者SQL文本命令</param>
        ///<return>返回查询结果</return>
        public static DataTable ExecuteDataTable(string commandText,CommandType commandType)
        {
            return ExecuteDataTable(commandText,commandType,null);
        }

        ///<summary>
        ///将CommandText发送到Connection并生成一个SqlDataReader
        ///</summary>
        ///<param name="commandText">要执行的SQL语句</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程中或者SQL文本命令</param>
        ///<param name="paramter">Transact-SQL语句或存储过程的参数数组</param>
        ///<return></return>
        public static SqlDataReader ExecuteReader(string commandText,CommandType commandType,SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(commandText,conn);
            cmd.CommandType = commandType;
            //如果同时传入了参数，则添加这些参数
            if( parameters != null)
            {
                foreach(SqlParameter paramter in parameters)
                {
                    cmd.Parameters.Add(paramter);
                }
            }
            conn.Open();
            //CommandBehavior参数指示关闭Reader对象是关闭与其关联的Connection对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        ///<summary>
        ///将CommandText发送到Connection并生成一个SqlDataReader
        ///</summary>
        ///<param name="commandText">要执行查询SQL文本命令</param>
        ///<return></return>
        public static SqlDataReader ExecuteReader(string commandText)
        {
            return ExecuteReader(commandText, CommandType.Text, null);
        }
        ///<summary>
        ///将CommandTetx发送到Connection并生成一个SqlDataReader
        ///</summary>
        ///<param name="commandText">要执行一个查询SQl文本命令</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程或者SQl文本命令</param>
        ///<return></return>
        public static SqlDataReader ExecuteReader(string commandText,CommandType commandType)
        {
            return ExecuteReader(commandText, commandType, null);
        }



        ///<summary>
        ///从数据库检索单个值（例如一个聚合值）
        ///</summary>
        ///<param name="commandText">要执行的SQL语句</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程中或者SQL文本命令</param>
        ///<param name="paramter">Transact-SQL语句或存储过程的参数数组</param>
        ///<return></return>
        public static Object ExectueScaler(string commandText,CommandType commandType,SqlParameter[] parameters)
        {
            object result = null;
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType=commandType;
                    //设置cmd的CommandType为指定的CommandType
                    //如果同时传入了参数，则添加这些参数
                    if(parameters != null)
                    {
                        foreach(SqlParameter paramter in parameters)
                        {
                            cmd.Parameters.Add(parameters);
                        }
                    }
                    conn.Open();
                    result = cmd.ExecuteReader();
                }
            }
            return result;
        }
        ///<summary>
        ///从数据库检索单个值（例如一个聚合值）
        ///</summary>
        ///<param name="commandText">要执行的SQL语句</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程中或者SQL文本命令</param>
        ///<return></return>
        public static Object ExecuteScalar(string commandText,CommandType commandType)
        {
            return ExectueScaler(commandText, commandType, null);
        }
        ///<summary>
        ///对数据库执行增加、删除、修改操作
        ///</summary>
        ///<param name="commandText">要执行的SQL语句</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程中或者SQL文本命令</param>
        ///<param name="paramter">Transact-SQL语句或存储过程的参数数组</param>
        ///<return>返回执行操作受影响的行数</return>
        public static int ExecuteNonQuery(string commandText,CommandType commandType,SqlParameter[] parameters)
        {
            int count = 0;
            using(SqlConnection conn = new SqlConnection())
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = commandType;
                    //设置cmd的CommandType为指定的CommandType
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SqlParameter paramter in parameters)
                        {
                            cmd.Parameters.Add((SqlParameter)paramter);
                        }
                    }
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;               //返回执行增加、删除、修改操作之后，数据库中受影响的行数
        }
        ///<summary>
        ///对数据库执行增加、删除、修改操作
        ///</summary>
        ///<param name="commandText">要执行的SQL语句</param>
        ///<param name="commandType">要执行的查询语句的类型，如存储过程中或者SQL文本命令</param>
        ///<return></return>
        public static int ExecuteNonQuery(string commamdText,CommandType commandType)
        {
            return ExecuteNonQuery(commamdText, commandType, null);
        }
    }
}
