using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_COMPANY
    {
        public void ADD_COMPANY(int prd_ID, string com_Name, string com_Phone, string com_Address)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@itemID", SqlDbType.Int);
            param[0].Value = prd_ID;

            param[1] = new SqlParameter("@CoName", SqlDbType.NVarChar, 50);
            param[1].Value = com_Name;

            param[2] = new SqlParameter("@CoPhone", SqlDbType.NChar,15);
            param[2].Value = com_Phone;

            param[3] = new SqlParameter("@CoAddress", SqlDbType.NVarChar, 100);
            param[3].Value = com_Address;

            DAL.ExecuteCommand("Insert_ItemsCompany", param);
            DAL.Close();

        }

        public DataTable GET_ALL_COMPANY()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAll_ItemsCompany", null);
            DAL.Close();
            return Dt;
        }

        public void EDIT_COMPANY(int prd_ID, string com_Name, string com_Phone, string com_Address)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@itemID", SqlDbType.Int);
            param[0].Value = prd_ID;

            param[1] = new SqlParameter("@CoName", SqlDbType.NVarChar, 50);
            param[1].Value = com_Name;

            param[2] = new SqlParameter("@CoPhone", SqlDbType.NChar, 15);
            param[2].Value = com_Phone;

            param[3] = new SqlParameter("@CoAddress", SqlDbType.NVarChar, 100);
            param[3].Value = com_Address;

            DAL.ExecuteCommand("Update_ItemsCompany", param);
            DAL.Close();

        }

        public void Delete_company(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_ItemsCompany", param);
            DAL.Close();
        }

        public DataTable GET_ALL_PRODUCTS()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllItems", null);
            DAL.Close();
            return Dt;
        }
    }
}
