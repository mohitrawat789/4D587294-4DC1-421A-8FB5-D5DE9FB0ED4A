﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Parking.Classes
{
    /// <summary>
    /// SqlDataAccess is being used for accessing MSSQL database quickly and easily. 
    /// Requires a connection string that is named MsSql defined on web.config file. This connection string is used as default. 
    /// For using different connection strings you should pass the name of the connection string as a parameter with methods.
    /// </summary>
    public class SqlDataAccess
    {
        // Default connection string. a connection named MsSql should be defined in web.config file.
        public const string CONNECTION_STRING_NAME = "MsSql";

        //This returns the connection string  
        private static string _connectionString = "Data Source=M2386946;Initial Catalog=db_Parking;Integrated Security=True";
        public static string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
                }
                return _connectionString;
            }
        }


        /// <summary>
        /// Brings a SqlCommand object to be able to add some parameters in it. After you send this to Execute method.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand GetCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(sql);
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        /// <summary>
        /// Datatable Döndür
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            //command.ExecuteNonQuery();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(SqlCommand command)
        {
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public int ExecuteStoredProcedure(string spName)
        {
            SqlCommand cmd = GetCommand(spName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteStoredProcedure(SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

    }
}