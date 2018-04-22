using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Zetalex.AutoNotifier.Helpers
{
    public class ClientDBConnection
    {
        private MySqlConnection connection;

        public ClientDBConnection(String connectionString)
        {
            Initialize(connectionString);
        }

        //Initialize values
        private void Initialize(String connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new AutoNotifierException("Error occurred while opening database connection for application, because of " + ex.Message);
            }
        }

        public MySqlConnection getConnectionObject()
        {
            return this.connection;
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new AutoNotifierException("Error occurred while closing database connection for application, because of " + ex.Message);
            }
        }


        public List<Dictionary<String, Object>> getQueryResults(String query)
        {
            List<Dictionary<String, Object>> result = new List<Dictionary<string, object>>();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Dictionary<String, Object> row = new Dictionary<string, object>();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    String col_name = dataReader.GetName(i);
                    Object value = dataReader.GetValue(i);
                    row.Add(col_name, value);
                }
                result.Add(row);
            }
            dataReader.Close();
            CloseConnection();
            return result;
        }

        public void Update(String query)
        {

            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public List<String> getAllTables()
        {
            List<String> result = new List<string>();
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = "show tables";
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    result.Add(dataReader.GetString(0));
                }
                dataReader.Close();



                //close connection
                this.CloseConnection();

            }
            return result;
        }
    }

    public class ApplicationDBConnection
    {
        private MySqlConnection connection;
        
        public ApplicationDBConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AppConnectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new AutoNotifierException("Error occurred while opening database connection for application, because of " + ex.Message); 
            }
        }

        public MySqlConnection getConnectionObject()
        {
            return this.connection;
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new AutoNotifierException("Error occurred while closing database connection for application, because of " + ex.Message);
            }
        }


        public List<Dictionary<String, Object>> getQueryResults(String query)
        {
            List<Dictionary<String, Object>> result = new List<Dictionary<string, object>>();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                Dictionary<String, Object> row = new Dictionary<string, object>();
                for(int i=0;i< dataReader.FieldCount;i++)
                {
                    String col_name = dataReader.GetName(i);
                    Object value = dataReader.GetValue(i);
                    row.Add(col_name, value);
                }
                result.Add(row);
            }
            dataReader.Close();
            CloseConnection();
            return result;
        }

        public void Update(String query)
        {
            
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public long Insert(String query)
        {
            //open connection
            long lastInsertId = -1;
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                lastInsertId= cmd.LastInsertedId;

                //close connection
                this.CloseConnection();
            }
            return lastInsertId;
        }

        public void batchInsert(List<String> queries)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                for(int i=0;i<queries.Count;i++)
                { 
                    MySqlCommand cmd = new MySqlCommand(queries[i], connection);
                    cmd.ExecuteNonQuery();
                }
                //Execute command
                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(String query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }

}
