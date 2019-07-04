using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_ORDERS
    {
        

        public DataTable GET_LAST_BILL_ID()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MaxSalesBill", null);
            DAL.Close();
            return Dt;
        }



        public void ADD_ORDERS(int ID, DateTime date, string OrderDescription, int CustID, string UserOrder)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@OrderDate", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@OrderDes", SqlDbType.NVarChar,200);
            param[2].Value = OrderDescription;

            param[3] = new SqlParameter("@CustID", SqlDbType.Int);
            param[3].Value = CustID;

            param[4] = new SqlParameter("@UserOrder", SqlDbType.NVarChar, 50);
            param[4].Value = UserOrder;


            DAL.ExecuteCommand("Insert_ItemOrder", param);
            DAL.Close();
        }



        public void ADD_ORDERS_DETAILS(string prd_ID, int order_ID,string prd_name,string prd_price,int prd_qte,float prd_discount, string prd_amount,string prd_total_amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ItemID", SqlDbType.VarChar,30);
            param[0].Value = prd_ID;

            param[1] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[1].Value = order_ID;

            param[2] = new SqlParameter("@itemName", SqlDbType.NVarChar,50);
            param[2].Value = prd_name;

            param[3] = new SqlParameter("@Price", SqlDbType.NVarChar,30);
            param[3].Value = prd_price;

            param[4] = new SqlParameter("@QTE", SqlDbType.Int);
            param[4].Value = prd_qte;

            param[5] = new SqlParameter("@Discount", SqlDbType.Float);
            param[5].Value = prd_discount;

            param[6] = new SqlParameter("@Amount", SqlDbType.NVarChar, 50);
            param[6].Value = prd_amount;

            param[7] = new SqlParameter("@TotalAmount", SqlDbType.NVarChar,50);
            param[7].Value = prd_total_amount;

            DAL.ExecuteCommand("Insert_ItemOrderDetails", param);
            DAL.Close();
        }



        public DataTable VerifyProductQte(string ID,int Qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ProductID", SqlDbType.VarChar, 30);
            param[0].Value = ID;
            param[1] = new SqlParameter("@QteEntered", SqlDbType.Int);
            param[1].Value = Qte;

            Dt = DAL.SelectData("VerifyProductQte", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GetproductBarcode(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Barcode", SqlDbType.VarChar, 30);
            param[0].Value = ID;
            Dt = DAL.SelectData("GetBarcode", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_Order()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllSalesOrder", null);
            DAL.Close();
            return Dt;
        }

        public void Delete_ORDER_mang(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteSalesBill", param);
            DAL.Close();
        }

        public DataTable GET_last_ORDER()      
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_last_ORDER", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ORDER_DETAILS(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("GET_ORDER_DETAILS", param);
            DAL.Close();
            return Dt;
        }

    }
}
