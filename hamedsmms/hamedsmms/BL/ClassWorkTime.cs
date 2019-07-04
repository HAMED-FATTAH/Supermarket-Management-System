using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class ClassWorkTime
    {
        public DataTable GET_ALL_Attend()      
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAttend", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GetUser_data(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            Dt = DAL.SelectData("Get_Data_USER", param);
            DAL.Close();
            return Dt;
        }

        public void InsertWorkTime(int ID, string Name, string UserType, DateTime AttenTime, DateTime DepartTime, DateTime PeriodTime, string State)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@UserType", SqlDbType.NVarChar, 40);
            param[2].Value = UserType;

            param[3] = new SqlParameter("@AttenTime", SqlDbType.DateTime);
            param[3].Value = AttenTime;

            param[4] = new SqlParameter("@DepartTime", SqlDbType.DateTime);
            param[4].Value = DepartTime;

            param[5] = new SqlParameter("@PeriodTime", SqlDbType.DateTime);
            param[5].Value = PeriodTime;

            param[6] = new SqlParameter("@State", SqlDbType.NVarChar ,10);
            param[6].Value = State;



            DAL.ExecuteCommand("InsertWorkTime", param);
            DAL.Close();

        }

        public void UpdateAttenState(string state, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@state", SqlDbType.NVarChar , 10);
            param[0].Value = state;

            param[1] = new SqlParameter("@UserID", SqlDbType.Int);
            param[1].Value = ID;


            DAL.ExecuteCommand("UpdateAttenState", param);
            DAL.Close();

        }

        public void UpdateDerartTime(DateTime DepartTime, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DepartTime", SqlDbType.DateTime);
            param[0].Value = DepartTime;

            param[1] = new SqlParameter("@UserID", SqlDbType.Int);
            param[1].Value = ID;


            DAL.ExecuteCommand("UpdateDerartTime", param);
            DAL.Close();

        }
    }
}
