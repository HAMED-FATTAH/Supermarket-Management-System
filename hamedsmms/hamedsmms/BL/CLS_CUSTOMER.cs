using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_CUSTOMER
    {
        public void ADD_CUSTOMERS(string Name, string Phone, string Email, string Address
            , DateTime date, byte[] Picture, string Useradd, string ImageState)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@CustName", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@CustPhone", SqlDbType.NChar, 11);
            param[1].Value = Phone;

            param[2] = new SqlParameter("@CustEmail", SqlDbType.NVarChar, 30);
            param[2].Value = Email;

            param[3] = new SqlParameter("@CustAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@CustDateAdd", SqlDbType.DateTime);
            param[4].Value = date;

            param[5] = new SqlParameter("@CustImage", SqlDbType.Image);
            param[5].Value = Picture;

            param[6] = new SqlParameter("@CustUserAdd", SqlDbType.NVarChar, 50);
            param[6].Value = Useradd;

            param[7] = new SqlParameter("@ImageState", SqlDbType.NVarChar, 50);
            param[7].Value = ImageState;


            DAL.ExecuteCommand("Insert_Customers", param);
            DAL.Close();
        }


        public void EDIT_CUSTOMERS(string Name, string Phone, string Email, string Address
            , DateTime date, byte[] Picture, string Useradd, string ImageState,int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[9];


            param[0] = new SqlParameter("@CustName", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@CustPhone", SqlDbType.NChar, 11);
            param[1].Value = Phone;

            param[2] = new SqlParameter("@CustEmail", SqlDbType.NVarChar, 30);
            param[2].Value = Email;

            param[3] = new SqlParameter("@CustAddress", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            param[4] = new SqlParameter("@CustDateAdd", SqlDbType.DateTime);
            param[4].Value = date;

            param[5] = new SqlParameter("@CustImage", SqlDbType.Image);
            param[5].Value = Picture;

            param[6] = new SqlParameter("@CustUserAdd", SqlDbType.NVarChar, 50);
            param[6].Value = Useradd;

            param[7] = new SqlParameter("@ImageState", SqlDbType.NVarChar, 50);
            param[7].Value = ImageState;

            param[8] = new SqlParameter("@CustID", SqlDbType.Int);
            param[8].Value = ID;

            DAL.ExecuteCommand("Update_Customers", param);
            DAL.Close();
        }

        public DataTable GET_ALL_CUSTOMERS()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAll_Customers", null);
            DAL.Close();
            return Dt;
        }

        public void DELETE_CUSTOMERS(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteCustomer", param);
            DAL.Close();
        }

        public DataTable SeachCustomer(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SEARCH", SqlDbType.NVarChar,50);
            param[0].Value = search;
            Dt = DAL.SelectData("SearchAll_Customers", param);
            DAL.Close();
            return Dt;
        }

        

    }
}
