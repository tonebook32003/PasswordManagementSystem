using System;
using System.Web.SessionState;
using Oracle.ManagedDataAccess.Client;

namespace PG_BMHTTT_PMS
{
     public static class ConnectDatabase
     {
          private static OracleConnection Conn; 
          public static bool Connect(string username, string password)
          {
               try
               {
                    string connString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
                    $"(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User ID={username};Password={password};";


                    if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
                    {
                         Conn.Close();
                         Conn.Dispose();
                    }
                    Conn = new OracleConnection(connString);
                    Conn.Open();
                    return true;
               }
               catch (Exception ex)
               {
                    Console.WriteLine($"Error connecting to Oracle database: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    return false;
               }
          }

          public static OracleConnection Get_Connect(string username, string password)
          {
               if (Conn == null || Conn.State != System.Data.ConnectionState.Open)
               {
                    Connect(username, password);
               }
               return Conn;
          }

          private static string GetCurrentSchema()
          {
               try
               {
                    using (OracleCommand cmd = new OracleCommand(
                        "SELECT SYS_CONTEXT('USERENV', 'CURRENT_SCHEMA') FROM DUAL", Conn))
                    {
                         return cmd.ExecuteScalar()?.ToString() ?? "Unknown";
                    }
               }
               catch
               {
                    return "Error getting schema";
               }
          }

          public static void Disconnect()
          {
               if (Conn != null)
               {
                    if (Conn.State == System.Data.ConnectionState.Open)
                    {
                         Conn.Close();
                    }
                    Conn.Dispose();
                    Conn = null;
               }
          }
          //public static OracleConnection Conn;
          //private static string Host = "localhost";
          //private static string Port = "1521";
          //private static string Sid = "orcl";


          //public static OracleConnection GetConnection(string user, string password)
          //{
          //     try
          //     {
          //          if (Conn == null || Conn.State == System.Data.ConnectionState.Closed)
          //          {
          //               string connString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={Host})(PORT={Port}))" +
          //                                   $"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={Sid})));User ID={user};Password={password};";

          //               Conn = new OracleConnection(connString);
          //               Conn.Open();
          //          }
          //          return Conn;
          //     }
          //     catch (Exception ex)
          //     {
          //          throw new Exception("Error while connecting to the database: " + ex.Message);
          //     }
          //}

          //public static void CloseConnection()
          //{
          //     if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
          //     {
          //          Conn.Close();
          //          Conn.Dispose();
          //          Conn = null;
          //     }
          //}

          //public static bool IsConnectionOpen()
          //{
          //     return Conn != null && Conn.State == System.Data.ConnectionState.Open;
          //}
     }
}