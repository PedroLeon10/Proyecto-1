using MySql.Data.MySqlClient;
using System;

namespace project_u5.data
{
    public class Connection
    {

        public static MySqlConnection CurrentConnection;

        public static String ConnectionString = @"server=localhost;uid=root;pwd=root;database=u1p1";

        public static bool Connect()
        {
            try
            {
                if (CurrentConnection != null && CurrentConnection.State == System.Data.ConnectionState.Open) return true;

                CurrentConnection = new MySqlConnection();
                CurrentConnection.ConnectionString = ConnectionString;
                CurrentConnection.Open();
                return true;

            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
            finally
            {

            }
            return false;
        }

        public static void Disconnect()
        {
            if(CurrentConnection != null && CurrentConnection.State == System.Data.ConnectionState.Open)
                CurrentConnection.Close();
                CurrentConnection.Dispose();
        }

    }
}
