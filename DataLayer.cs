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
        public static string _DBConnectionString = "";

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
    }
}
