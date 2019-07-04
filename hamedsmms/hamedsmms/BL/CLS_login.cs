using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace hamedsmms.BL
{
    class CLS_login
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 20);
            param[1].Value = PWD;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("CHKLogin", param);
            DAL.Close();
            return Dt;
        }
    }
}
