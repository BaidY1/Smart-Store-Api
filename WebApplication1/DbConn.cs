using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace WebApplication1
{
    public class DbConnectivity
    {



        public MySqlConnection dbConn;
        public void createConn()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            dbConn = new MySqlConnection(connectionString);




            try
            {
                dbConn.Open();

            }
            catch (Exception ex)
            {
                dbConn.Close();
            }
        }



        public void closeConn()
        {
            try
            {
                if (dbConn != null)
                {
                    dbConn.Close();
                }
            }
            catch(Exception e)
            {

            }

        }
        public void exectueQuery(MySqlConnection mySqlConnection, string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, mySqlConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();




            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                }
            }




        }
    }




}