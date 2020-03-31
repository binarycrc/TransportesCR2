using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TransportesCR2
{
    class DataLayer
    {
        public static SqlCommand commandData = new SqlCommand();
        public static SqlConnection sqlConnData = new SqlConnection();
        public string _LatestError = "";
        public static string _ServerDataSource = "BINARYCRCD2x";
        public static string _ServerInitialCatalog = "TransportesCR";
        public static string _DBConnectionString = "Data Source=" + _ServerDataSource + ";Initial Catalog=" + _ServerInitialCatalog + ";Trusted_Connection=yes;";

        public DataLayer() { }
        public DataLayer(string ServerDataSource, string ServerInitialCatalog)
        {
            _ServerDataSource = ServerDataSource;
            _ServerInitialCatalog = ServerInitialCatalog;
            _DBConnectionString = "Data Source=" + _ServerDataSource + ";Initial Catalog=" + _ServerInitialCatalog + ";Trusted_Connection=yes;";
        }
        #region "Connection open and close"
        public bool OpenData(string strType)
        {
            try 
            {
                if (strType == "sp") { commandData.CommandType = CommandType.StoredProcedure; }
                else { commandData.CommandType = CommandType.Text; }
                sqlConnData.ConnectionString = _DBConnectionString;
                commandData.Connection = sqlConnData;
                if (sqlConnData.State != ConnectionState.Open) { sqlConnData.Open(); }
                if (sqlConnData.State == ConnectionState.Open) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "datelayer.OpenData");
                _LatestError = ex.Message;
                return false;
            }
        }
        public void CloseData()
        {
            try
            {
                sqlConnData.Close();
            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "datelayer.CloseData");
            }
        }
        public bool testData()
        {
            bool result = false;
            try
            {
                CloseData();
                if (OpenData("query"))
                {
                    CloseData();
                    result = true;
                }
                else
                    result = false;
            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "datelayer.testdb");
                result = false;
            }
            return result;
        }
        #endregion //"Connection open and close"
    }
}
