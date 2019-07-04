using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_RETURN_ORDER
    {
        public DataTable GET_RETURN_ORDER()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_ReturnItem", null);

            DAL.Close();
            return Dt;
        }

        public void ADD_RETURN_ORDER(int R_ID, int O_ID, string R_Pro, string R_Price, int qte, int R_DIS,
                             string R_Total, DateTime date, string R_User, string Status, string Notes, int ITEM_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@ReturnID", SqlDbType.Int);
            param[0].Value = R_ID;

            param[1] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[1].Value = O_ID;

            param[2] = new SqlParameter("@ReturnItem", SqlDbType.NVarChar, 50);
            param[2].Value = R_Pro;

            param[3] = new SqlParameter("@ReturnPrice", SqlDbType.NVarChar, 50);
            param[3].Value = R_Price;

            param[4] = new SqlParameter("@ReturnQTE", SqlDbType.Int);
            param[4].Value = qte;

            param[5] = new SqlParameter("@ReturnDiscount", SqlDbType.Int);
            param[5].Value = R_DIS;

            param[6] = new SqlParameter("@ReturnTotal", SqlDbType.NVarChar, 50);
            param[6].Value = R_Total;

            param[7] = new SqlParameter("@ReturnDate", SqlDbType.DateTime);
            param[7].Value = date;

            param[8] = new SqlParameter("@UserReturn", SqlDbType.NVarChar, 50);
            param[8].Value = R_User;

            param[9] = new SqlParameter("@StatusID", SqlDbType.NVarChar, 50);
            param[9].Value = Status;

            param[10] = new SqlParameter("@Note", SqlDbType.NVarChar, 100);
            param[10].Value = Notes;

            param[11] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[11].Value = ITEM_ID;

            DAL.ExecuteCommand("Insert_ReturnItem", param);
            DAL.Close();

        }

        public void Update_RETURN_ORDER(int R_ID, int O_ID, string R_Pro, string R_Price, int qte, int R_DIS,
                             string R_Total, DateTime date, string R_User, string Status, string Notes , int ITEM_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@ReturnID", SqlDbType.Int);
            param[0].Value = R_ID;

            param[1] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[1].Value = O_ID;

            param[2] = new SqlParameter("@ReturnItem", SqlDbType.NVarChar,50);
            param[2].Value = R_Pro;

            param[3] = new SqlParameter("@ReturnPrice", SqlDbType.NVarChar, 50);
            param[3].Value = R_Price;

            param[4] = new SqlParameter("@ReturnQTE", SqlDbType.Int);
            param[4].Value = qte;

            param[5] = new SqlParameter("@ReturnDiscount", SqlDbType.Int);
            param[5].Value = R_DIS;

            param[6] = new SqlParameter("@ReturnTotal", SqlDbType.NVarChar,50);
            param[6].Value = R_Total;

            param[7] = new SqlParameter("@ReturnDate", SqlDbType.DateTime);
            param[7].Value = date;

            param[8] = new SqlParameter("@UserReturn", SqlDbType.NVarChar, 50);
            param[8].Value = R_User;

            param[9] = new SqlParameter("@StatusID", SqlDbType.NVarChar,50);
            param[9].Value = Status;

            param[10] = new SqlParameter("@Note", SqlDbType.NVarChar,100);
            param[10].Value = Notes;

            param[11] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[11].Value = ITEM_ID;

            DAL.ExecuteCommand("Update_ReturnItem", param);
            DAL.Close();

        }

        public void Delete_R_ORDER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_ReturnItem", param);
            DAL.Close();
        }

        public DataTable GET_R_order()      // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAll_ReturnItem", null);

            DAL.Close();
            return Dt;
        }

        public DataTable MAX_R_ORDER_ID()       
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MaxID_ReturnItem", null);

            DAL.Close();
            return Dt;
        }

        public void UpdateReturn_Status(string ID,int R_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@ReturnID", SqlDbType.Int);
            param[1].Value = R_ID;

            DAL.ExecuteCommand("UpdateReturn_Status", param);
            DAL.Close();
        }

        public void UpdateReturnQTE(int PRO_ID,int QTE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[0].Value = PRO_ID;

            param[1] = new SqlParameter("@QTE", SqlDbType.Int);
            param[1].Value = QTE;

            DAL.ExecuteCommand("UpdateReturnQTE", param);
            DAL.Close();
        }
    }
}
