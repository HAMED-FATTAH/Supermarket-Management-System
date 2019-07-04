using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_USER
    {
        DAL.DataAccessLayer dataaccess = new DAL.DataAccessLayer();



        public void AddUser(int userid, string username, string userPW, string userFname, DateTime date,
            string usertype, int userphone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] paramer = new SqlParameter[7];



            paramer[0] = new SqlParameter("@UserID", SqlDbType.Int);
            paramer[0].Value = userid;

            paramer[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            paramer[1].Value = username;

            paramer[2] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 20);
            paramer[2].Value = userPW;

            paramer[3] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 50);
            paramer[3].Value = userFname;

            paramer[4] = new SqlParameter("@UserDateT", SqlDbType.DateTime);
            paramer[4].Value = date;

            paramer[5] = new SqlParameter("@UserType", SqlDbType.NVarChar, 40);
            paramer[5].Value = usertype;

            paramer[6] = new SqlParameter("@Userphone", SqlDbType.Int);
            paramer[6].Value = userphone;

            DAL.ExecuteCommand("AddUser", paramer);
            DAL.Close();
        }

        public void Update_User(int userid, string username, string userPW, string userFname, DateTime date,
            string usertype, int userphone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] paramer = new SqlParameter[7];

            paramer[0] = new SqlParameter("@ID", SqlDbType.Int);
            paramer[0].Value = userid;

            paramer[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            paramer[1].Value = username;

            paramer[2] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 20);
            paramer[2].Value = userPW;

            paramer[3] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 50);
            paramer[3].Value = userFname;

            paramer[4] = new SqlParameter("@UserDateT", SqlDbType.DateTime);
            paramer[4].Value = date;

            paramer[5] = new SqlParameter("@UserType", SqlDbType.NVarChar, 40);
            paramer[5].Value = usertype;

            paramer[6] = new SqlParameter("@Userphone", SqlDbType.Int);
            paramer[6].Value = userphone;

            DAL.ExecuteCommand("UpdateUsers", paramer);
            DAL.Close();

        }

        public void DELETE_USER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteUser", param);
            DAL.Close();
        }

        public DataTable SeachUsers(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar, 50);
            param[0].Value = search;
            Dt = DAL.SelectData("SearchAllUsers", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_USER()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("AllUsers", null);
            DAL.Close();
            return Dt;
        }

        public DataTable VerifyUserID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerifyUserID", param);
            DAL.Close();
            return Dt;
        }
    }
}
