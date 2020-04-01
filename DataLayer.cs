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

        public static SqlConnection sqlConnData = new SqlConnection();
        public string _LatestError = "";
        public static string _ServerDataSource = "BINARYCRCD2";
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
            SqlCommand commandData = new SqlCommand();
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
                _LatestError = ex.Message;
                result = false;
            }
            return result;
        }
        #endregion //"Connection open and close"

        #region "Conductor"
        public bool ExisteConductor(string prmIdentificacion) 
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query");
                commandData = new System.Data.SqlClient.SqlCommand("SELECT * FROM [Conductor] with(nolock) " +
                    "where Identificacion = @Identificacion", sqlConnData);
                commandData.CommandType = CommandType.Text;
                commandData.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar,10);
                commandData.Parameters["@Identificacion"].Value = prmIdentificacion.Trim();
                reader = commandData.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    CloseData();
                    return true;
                }
                else 
                {
                    reader.Close();
                    CloseData();
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;
                CloseData();
                return false;
            }

        }
        public bool GuardaConductor(string prmIdentificacion, string prmNombre, string prmPrimerApellido, string prmSegundoApellido, string prmRutaAsignada) 
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                commandData = new System.Data.SqlClient.SqlCommand("INSERT INTO [Conductor]([Identificacion],[Nombre],[PrimerApeliido],[SegundoApellido],[RutaAsignada])VALUES(@Identificacion,@Nombre,@PrimerApellido,@SegundoApellido,@RutaAsignada)", sqlConnData);
                commandData.CommandType = CommandType.Text;
                commandData.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Identificacion"].Value = prmIdentificacion.Trim();
                commandData.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Nombre"].Value = prmNombre.Trim();
                commandData.Parameters.Add("@PrimerApellido", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@PrimerApellido"].Value = prmPrimerApellido.Trim();
                commandData.Parameters.Add("@SegundoApellido", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@SegundoApellido"].Value = prmSegundoApellido.Trim();
                commandData.Parameters.Add("@RutaAsignada", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@RutaAsignada"].Value = prmRutaAsignada.Trim();

                if (ExisteConductor(prmIdentificacion) == false)
                {
                    OpenData("query");
                    commandData.ExecuteNonQuery();
                    CloseData();
                    _LatestError = "Conductor "+ prmIdentificacion.Trim() + " agregado satisfactoriamente.";
                    return true;
                }
                else
                {
                    _LatestError = "Conductor ya existe";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;
                CloseData();
                return false;
            }
        }
        public Dictionary<string, Conductor> GetConductores(string prmBuscar) 
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            Dictionary<string, Conductor> Conductores = new Dictionary<string, Conductor>();
                OpenData("query");
            if (!string.IsNullOrEmpty(prmBuscar.Trim()))
            {
                commandData = new System.Data.SqlClient.SqlCommand("SELECT [Identificacion],[Nombre],[PrimerApeliido],[SegundoApellido],[RutaAsignada] FROM [Conductor] with(nolock) " +
                    "where Identificacion like '%'+@Identificacion+'%' " +
                    "or Nombre like '%'+@Nombre+'%' " +
                    "or PrimerApeliido like '%'+@PrimerApellido+'%' " +
                    "or SegundoApellido like '%'+@SegundoApellido+'%' " +
                    "or RutaAsignada like '%'+@RutaAsignada+'%' " +
                    "order by Identificacion", sqlConnData);
                commandData.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Identificacion"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Nombre"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@PrimerApellido", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@PrimerApellido"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@SegundoApellido", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@SegundoApellido"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@RutaAsignada", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@RutaAsignada"].Value = prmBuscar.Trim();

            }
            else
            {
                commandData = new System.Data.SqlClient.SqlCommand("SELECT [Identificacion],[Nombre],[PrimerApeliido],[SegundoApellido],[RutaAsignada] FROM [Conductor] with(nolock) order by Identificacion", sqlConnData);
            }
                
                commandData.CommandType = CommandType.Text;
                reader = commandData.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Conductor conductor = new Conductor(reader["Identificacion"].ToString()
                            , reader["Nombre"].ToString()
                            , reader["PrimerApeliido"].ToString()
                            , reader["SegundoApellido"].ToString()
                            , reader["RutaAsignada"].ToString()
                            );
                        Conductores.Add(conductor.Identificacion, conductor);
                    }
                    reader.Close();
                }
                CloseData();
                return Conductores;
        }
        #endregion //"Conductor"

        #region "Camion"
        public bool ExisteCamion(string prmPlaca)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query");
                commandData = new System.Data.SqlClient.SqlCommand("SELECT * FROM [Camion] with(nolock) " +
                    "where Placa = @Placa", sqlConnData);
                commandData.CommandType = CommandType.Text;
                commandData.Parameters.Add("@Placa", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Placa"].Value = prmPlaca.Trim();
                reader = commandData.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    CloseData();
                    return true;
                }
                else
                {
                    reader.Close();
                    CloseData();
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;
                CloseData();
                return false;
            }

        }
        //if (!datalayer.GuardaCamion(txtPlaca.Text, numModelo.Text, cbMarca.SelectedText, txtCapKilos.Text, txtCapVolumen.Text))
        public bool GuardaCamion(string prmPlaca, string prmModelo, string prmMarca, string prmCapKilos, string prmCapVolumen)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                   commandData = new System.Data.SqlClient.SqlCommand("INSERT INTO [Camion]([Placa],[AnnoModelo],[Marca],[CapacidadKG],[CapacidadVl])" +
                       "VALUES(@Placa,@AnnoModelo,@Marca,@CapacidadKG,@CapacidadVl)", sqlConnData);
                commandData.CommandType = CommandType.Text;
                commandData.Parameters.Add("@Placa", System.Data.SqlDbType.VarChar, 8);
                commandData.Parameters["@Placa"].Value = prmPlaca.Trim();
                commandData.Parameters.Add("@AnnoModelo", System.Data.SqlDbType.VarChar, 4);
                commandData.Parameters["@AnnoModelo"].Value = prmModelo.Trim();
                commandData.Parameters.Add("@Marca", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Marca"].Value = prmMarca.Trim();
                commandData.Parameters.Add("@CapacidadKG", System.Data.SqlDbType.Decimal);
                commandData.Parameters["@CapacidadKG"].Value = Convert.ToDecimal(prmCapKilos.Trim());
                commandData.Parameters.Add("@CapacidadVl", System.Data.SqlDbType.Decimal);
                commandData.Parameters["@CapacidadVl"].Value = Convert.ToDecimal(prmCapVolumen.Trim());

                if (ExisteCamion(prmPlaca) == false)
                {
                    OpenData("query");
                    commandData.ExecuteNonQuery();
                    CloseData();
                    _LatestError = "Camion " + prmPlaca.Trim() + " agregado satisfactoriamente.";
                    return true;
                }
                else
                {
                    _LatestError = "Camion ya existe";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;
                CloseData();
                return false;
            }
        }
        public Dictionary<string, Camion> GetCamiones(string prmBuscar)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            Dictionary<string, Camion> Camioniones = new Dictionary<string, Camion>();
            OpenData("query");
            if (!string.IsNullOrEmpty(prmBuscar.Trim()))
            {
               commandData = new System.Data.SqlClient.SqlCommand("SELECT [Placa],[AnnoModelo],[Marca],[CapacidadKG],[CapacidadVl] FROM [Camion] with(nolock) " +
                    "where Placa like '%'+@Placa+'%' " +
                    "or AnnoModelo like '%'+@AnnoModelo+'%' " +
                    "or Marca like '%'+@Marca+'%' " +
                    "order by Placa", sqlConnData);
                commandData.Parameters.Add("@Placa", System.Data.SqlDbType.VarChar, 8);
                commandData.Parameters["@Placa"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@AnnoModelo", System.Data.SqlDbType.VarChar, 4);
                commandData.Parameters["@AnnoModelo"].Value = prmBuscar.Trim();
                commandData.Parameters.Add("@Marca", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Marca"].Value = prmBuscar.Trim();
            }
            else
            {
                commandData = new System.Data.SqlClient.SqlCommand("SELECT [Placa],[AnnoModelo],[Marca],[CapacidadKG],[CapacidadVl] FROM [Camion] with(nolock) order by Placa", sqlConnData);
            }

            commandData.CommandType = CommandType.Text;
            reader = commandData.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Camion camion = new Camion(reader["Placa"].ToString()
                        , reader["AnnoModelo"].ToString()
                        , reader["Marca"].ToString()
                        , reader["CapacidadKG"].ToString()
                        , reader["CapacidadVl"].ToString()
                        );
                    Camioniones.Add(camion.Placa, camion);
                }
                reader.Close();
            }
            CloseData();
            return Camioniones;
        }

        public Dictionary<string, string> GetConductorxCamion(string prmBuscar, int prmAssigned)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            Dictionary<string, string> Camioniones = new Dictionary<string, string>();
            OpenData("query");
            if (!string.IsNullOrEmpty(prmBuscar.Trim()))
            {
                commandData = new System.Data.SqlClient.SqlCommand("SELECT [Placa],Detalles= trim([Placa])+' / '+trim([Marca])+'('+trim([AnnoModelo])+') '+trim(convert(varchar,convert(decimal(8,2),[CapacidadKG]))) FROM [Camion] with(nolock) " +
                     " ", sqlConnData);
                //where Placa = @Placa 
                commandData.Parameters.Add("@Placa", System.Data.SqlDbType.VarChar, 8);
                commandData.Parameters["@Placa"].Value = prmBuscar.Trim();
            }

            commandData.CommandType = CommandType.Text;
            reader = commandData.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Camioniones.Add(reader["Placa"].ToString(), reader["Detalles"].ToString());
                }
                reader.Close();
            }
            CloseData();
            return Camioniones;
        }
        #endregion //"Camion"

    }
}
