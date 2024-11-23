using System;
using Oracle.ManagedDataAccess.Client;

namespace PG_BMHTTT_PMS
{
     public static class ConnectDatabase
     {
          private static OracleConnection Conn;

          public static bool Connect()
          {
               try
               {
                    string connString = "Data Source=(DESCRIPTION=" +
                        "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                        "(HOST=localhost)(PORT=1521)))" +
                        "(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));" +
                        "User Id=c##PG_BMHTTT_PMS;Password=123;" +
                        "Connection Timeout=60;";

                    if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
                    {
                         Conn.Close();
                         Conn.Dispose();
                    }

                    Conn = new OracleConnection(connString);
                    Conn.Open();

                    Console.WriteLine("Connected to Oracle database successfully!");
                    //Console.WriteLine($"Connection State: {Conn.State}");
                    //Console.WriteLine($"Server Version: {Conn.ServerVersion}");
                    //Console.WriteLine($"Current Schema: {GetCurrentSchema()}");

                    return true;
               }
               catch (Exception ex)
               {
                    Console.WriteLine($"Error connecting to Oracle database: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    return false;
               }
          }

          public static OracleConnection Get_Connect()
          {
               if (Conn == null || Conn.State != System.Data.ConnectionState.Open)
               {
                    Connect();
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

          // Thêm method để đóng connection
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
     }
}