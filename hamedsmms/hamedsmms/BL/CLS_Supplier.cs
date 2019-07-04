using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hamedsmms.BL
{
    class CLS_Supplier
    {
        DAL.DataAccessLayer dataaccess = new DAL.DataAccessLayer();
        DataTable dt;

        public DataTable SupMaxID()
        {
            dt = new DataTable();
            dt = dataaccess.SelectData("MaxSuppID", null);
            return dt;
        }

        public void AddSupplier(string supName, string supPhone, string supEmail, string supCompany, string supAddress,
           DateTime supdateadd, string supuseradd)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] paramer = new SqlParameter[7];

            

            paramer[0] = new SqlParameter("@SuppName", SqlDbType.NVarChar, 50);
            paramer[0].Value = supName;

            paramer[1] = new SqlParameter("@SuppPhone", SqlDbType.NVarChar, 20);
            paramer[1].Value = supPhone;

            paramer[2] = new SqlParameter("@SuppEmail", SqlDbType.NVarChar, 30);
            paramer[2].Value = supEmail;

            paramer[3] = new SqlParameter("@SuppCompany", SqlDbType.NVarChar, 50);
            paramer[3].Value = supCompany;

            paramer[4] = new SqlParameter("@SuppAddress", SqlDbType.NVarChar, 50);
            paramer[4].Value = supAddress;

            paramer[5] = new SqlParameter("@SuppDateAdd", SqlDbType.DateTime);
            paramer[5].Value = supdateadd;

            paramer[6] = new SqlParameter("@SuppUserAdd", SqlDbType.NVarChar, 50);
            paramer[6].Value = supuseradd;

            DAL.ExecuteCommand("AddSupplier", paramer);
            DAL.Close();
        }

        public void UpdateSupplier(int supID, string supName, string supPhone, string supEmail, string supCompany, 
            string supAddress,DateTime supdateadd, string supuseradd)
        {

            dataaccess.Open();

            SqlParameter[] paramer = new SqlParameter[8];

            paramer[0] = new SqlParameter("@SuppID", SqlDbType.Int);
            paramer[0].Value = supID;

            paramer[1] = new SqlParameter("@SuppName", SqlDbType.NVarChar, 50);
            paramer[1].Value = supName;

            paramer[2] = new SqlParameter("@SuppPhone", SqlDbType.NVarChar, 20);
            paramer[2].Value = supPhone;

            paramer[3] = new SqlParameter("@SuppEmail", SqlDbType.NVarChar, 30);
            paramer[3].Value = supEmail;

            paramer[4] = new SqlParameter("@SuppCompany", SqlDbType.NVarChar, 50);
            paramer[4].Value = supCompany;

            paramer[5] = new SqlParameter("@SuppAddress", SqlDbType.NVarChar, 50);
            paramer[5].Value = supAddress;

            paramer[6] = new SqlParameter("@SuppDateAdd", SqlDbType.DateTime);
            paramer[6].Value = supdateadd;

            paramer[7] = new SqlParameter("@SuppUserAdd", SqlDbType.NVarChar, 50);
            paramer[7].Value = supuseradd;

            dataaccess.ExecuteCommand("UpdateSupplier", paramer);
            dataaccess.Close();
        }

        public void DeleteSupplier(int sup_ID)
        {
            dataaccess.Open();
            SqlParameter[] paramer = new SqlParameter[1];

            paramer[0] = new SqlParameter("@SuppID", SqlDbType.Int);
            paramer[0].Value = sup_ID;

            dataaccess.ExecuteCommand("DeleteSupplier", paramer);
            dataaccess.Close();

        }

        public DataTable ViewAllSupplier()
        {
            dt = new DataTable();
            dt = dataaccess.SelectData("ViewAllSupplier", null);
            return dt;
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

        public DataTable GET_ALL_Supplier()       // no enteres any parameters becouse we need every parameters.
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetAllSupplier", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SeachSupplier(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = search;
            Dt = DAL.SelectData("SearchAllSupp", param);
            DAL.Close();
            return Dt;
        }


        public void Deletesupplier(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SuppID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteSupplier", param);
            DAL.Close();

        }

    }
}
