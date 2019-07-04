using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_PLACE
    {
        public DataTable GET_ALL_PRODUCTS()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllItems", null);
            DAL.Close();
            return Dt;
        }

        public void ADD_place(int prd_ID, string flour, string stand, string place)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[0].Value = prd_ID;

            param[1] = new SqlParameter("@PlFloar", SqlDbType.NVarChar, 50);
            param[1].Value = flour;

            param[2] = new SqlParameter("@PlStand", SqlDbType.NVarChar,50);
            param[2].Value = stand;

            param[3] = new SqlParameter("@PlPlace", SqlDbType.NVarChar, 50);
            param[3].Value = place;

            DAL.ExecuteCommand("Insert_Places", param);
            DAL.Close();

        }

        public void Update_Places(int itemID, string flour, string stand, string place)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[0].Value = itemID;

            param[1] = new SqlParameter("@PlFloar", SqlDbType.NVarChar, 50);
            param[1].Value = flour;

            param[2] = new SqlParameter("@PlStand", SqlDbType.NVarChar,50);
            param[2].Value = stand;

            param[3] = new SqlParameter("@PlPlace", SqlDbType.NVarChar, 50);
            param[3].Value = place;

            DAL.ExecuteCommand("Update_Places", param);
            DAL.Close();
        }

        public void Delete_Places(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Places", param);
            DAL.Close();
        }

        public DataTable GET_ALL_Places()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAll_Places", null);
            DAL.Close();
            return Dt;
        }
    }
}
