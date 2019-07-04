using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_PURCHASE
    {
        public DataTable GET_LAST_PURCHASE_ID()      // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MaxPurchaseID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GAT_purchase_Details()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAll_PurchaseOrderDetails", null);
            DAL.Close();
            return Dt;

        }

        public DataTable GAT_purchase_Manger()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPurchaseManager", null);
            DAL.Close();
            return Dt;

        }



        public void Delete_PUR_mang(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeletePurBill", param);
            DAL.Close();
        }

        public void ADD_Purchase(int PurOrderID, DateTime PurOrderDate, string PurOrderDes, int PurSuppID, string UserOrder)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@PurOrderID", SqlDbType.Int);
            param[0].Value = PurOrderID;

            param[1] = new SqlParameter("@PurOrderDate", SqlDbType.DateTime);
            param[1].Value = PurOrderDate;

            param[2] = new SqlParameter("@PurOrderDes", SqlDbType.NVarChar, 200);
            param[2].Value = PurOrderDes;

            param[3] = new SqlParameter("@PurSuppID", SqlDbType.Int);
            param[3].Value = PurSuppID;

            param[4] = new SqlParameter("@UserOrder", SqlDbType.NVarChar, 50);
            param[4].Value = UserOrder;


            DAL.ExecuteCommand("AddPurchase", param);
            DAL.Close();
        }



        public void ADD_ORDERS_DETAILS(int PurOrderID, string OrBill, string Barcode, string itemName, string PurPrice, int QTE, string PriceUnit, string State, string Amount)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@PurOrderID", SqlDbType.Int);
            param[0].Value = PurOrderID;

            param[1] = new SqlParameter("@OrBill", SqlDbType.NVarChar, 50);
            param[1].Value = OrBill;

            param[2] = new SqlParameter("@Barcode", SqlDbType.NVarChar, 50);
            param[2].Value = Barcode;

            param[3] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
            param[3].Value = itemName;

            param[4] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 30);
            param[4].Value = PurPrice;

            param[5] = new SqlParameter("@QTE", SqlDbType.Int);
            param[5].Value = QTE;

            param[6] = new SqlParameter("@PriceUnit", SqlDbType.NVarChar, 30);
            param[6].Value = PriceUnit;

            param[7] = new SqlParameter("@State", SqlDbType.NVarChar, 50);
            param[7].Value = State;


            param[8] = new SqlParameter("@Amount", SqlDbType.NVarChar, 30);
            param[8].Value = Amount;

            DAL.ExecuteCommand("Insert_PurchaseOrderDetails", param);
            DAL.Close();
        }

        
    }
}
