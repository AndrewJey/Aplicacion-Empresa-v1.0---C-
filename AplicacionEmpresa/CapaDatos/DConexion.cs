using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DConexion
    {
        private const string DefaultEmpresaConnection = "Data Source=.\\SQLEXPRESS; Initial Catalog=BDEmpresa; Integrated Security=SSPI;";
        private const string DefaultMasterConnection = "Data Source=.\\SQLEXPRESS; Initial Catalog=master; Integrated Security=SSPI;";

        private static string _cnBDEmpresaOverride;
        private static string _cnMasterOverride;

        public static string CnBDEmpresa
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_cnBDEmpresaOverride))
                {
                    return _cnBDEmpresaOverride;
                }

                string env = Environment.GetEnvironmentVariable("EMPRESA_CONNECTION_STRING");
                if (!string.IsNullOrWhiteSpace(env))
                {
                    return env.Trim();
                }

                return DefaultEmpresaConnection;
            }
            set { _cnBDEmpresaOverride = value; }
        }

        public static string CnMaster
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_cnMasterOverride))
                {
                    return _cnMasterOverride;
                }

                string env = Environment.GetEnvironmentVariable("EMPRESA_MASTER_CONNECTION_STRING");
                if (!string.IsNullOrWhiteSpace(env))
                {
                    return env.Trim();
                }

                return DefaultMasterConnection;
            }
            set { _cnMasterOverride = value; }
        }

        public string ChequearConexion()
        {
            try
            {
                using (SqlConnection sqlConexion = new SqlConnection(DConexion.CnBDEmpresa))
                {
                    sqlConexion.Open();
                    return "Y";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
