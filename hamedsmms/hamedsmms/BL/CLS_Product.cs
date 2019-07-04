using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace hamedsmms.BL
{
    class CLS_Product
    {
        public DataTable GET_ALL_CATEGORIES()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("AllCategory", null);
            DAL.Close();
            return Dt;
        }
        public void UPDATE_STATE(string ID, string State, string itemName)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@State", SqlDbType.NVarChar, 50);
            param[1].Value = State;

            param[2] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
            param[2].Value = itemName;

            DAL.ExecuteCommand("UpdateState", param);
            DAL.Close();
        }

        public void ADD_PRODUCTS(string ID, string Name, DateTime date, string Pur, string Sale, int qte, int CatID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

         
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@itemID", SqlDbType.NVarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@itemDate", SqlDbType.DateTime);
            param[2].Value = date;

            param[3] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 30);
            param[3].Value = Pur;

            param[4] = new SqlParameter("@SalePrice", SqlDbType.NVarChar, 30);
            param[4].Value = Sale;

            param[5] = new SqlParameter("@itemQTE", SqlDbType.Int);
            param[5].Value = qte;

            param[6] = new SqlParameter("@CatID", SqlDbType.Int);
            param[6].Value = CatID;

            DAL.ExecuteCommand("Insert_Items", param);
            DAL.Close();
            
        }




        public void Update_PRODUCTS(string ID, string Name, DateTime date, string Pur, string Sale, int qte, int CatID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@itemID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@itemDate", SqlDbType.DateTime);
            param[2].Value = date;

            param[3] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 30);
            param[3].Value = Pur;

            param[4] = new SqlParameter("@SalePrice", SqlDbType.NVarChar, 30);
            param[4].Value = Sale;

            param[5] = new SqlParameter("@itemQTE", SqlDbType.Int);
            param[5].Value = qte;

            param[6] = new SqlParameter("@CatID", SqlDbType.Int);
            param[6].Value = CatID;

            DAL.ExecuteCommand("Update_Items", param);
            DAL.Close();

        }

        public DataTable VerifyProductID(string ID)       
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value=ID;
            Dt = DAL.SelectData("VerifyProductID", param);
            DAL.Close();
            return Dt;
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

        public DataTable SeachProduct(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 30);
            param[0].Value = search;
            Dt = DAL.SelectData("Search_AllItems", param);
            DAL.Close();
            return Dt;
        }

        public void DeleteProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteItems", param);
            DAL.Close();

        }

       
        

        


    }
}
