using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace hamedsmms.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //This Constructor Inisialize the connection object
        public DataAccessLayer()
        {
            string s = "Data Source=DESKTOP-SUFKOGM;Initial Catalog=SMMS;Integrated Security=True";
            sqlconnection = new SqlConnection(s);
        }

        //Method to open the connection 
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method to read data from database 
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //Method to Insert, Update, and Delete data from database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcomand = new SqlCommand();
            sqlcomand.CommandType = CommandType.StoredProcedure;
            sqlcomand.CommandText = stored_procedure;
            sqlcomand.Connection = sqlconnection;

            if (param != null)
            {

                sqlcomand.Parameters.AddRange(param);

            }
            sqlcomand.ExecuteNonQuery();
        }
    }
}