
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theProject
{
    class DatabaseClass
    {
        SqlConnection connection;
        //constructor containing the connection
        public DatabaseClass()
        {
            try
            { 
                connection = new SqlConnection(@"Server=DESKTOP-105P2J0;Database=BitCompany;Trusted_Connection=True;");
            }
            catch(Exception es)
            {
                MessageBox.Show(es.ToString());
            }

        }
        public SqlConnection conn()
        {
            connection = new SqlConnection(@"Server=DESKTOP-105P2J0;Database=BitCompany;Trusted_Connection=True;");
            return connection;
        }
        
        //open connection
        public void openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        //close connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlCommand cmd(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                openConnection();
                command.ExecuteNonQuery();
                closeConnection();
                return command;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
                return null;
            }

        }

        public SqlCommand cmd(string query,params SqlParameter[] parameteres)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameteres);
                openConnection();
                command.ExecuteNonQuery();
                closeConnection();
                return command;
            }
            catch(Exception es)
            {
                MessageBox.Show(es.ToString());
                return null;
            }
            
        }

        public DataTable returnDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            openConnection();
            dt.Load(cmd.ExecuteReader());
            closeConnection();

            return dt;
        }
        
        //select query
        //public DataTable selectQuery(string query, List<SqlParameter> par)
        //{
        //    try
        //    {
        //        openConnection();

        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue

        //        DataTable data = new DataTable();
        //        data.Load(cmd.ExecuteReader());

        //        closeConnection();
        //        return data;

        //    }
        //    catch(Exception es)
        //    {
        //        MessageBox.Show(es.ToString());
        //        return null;
        //    }
            
        //}
        /*
        // method to select the data from database 
        public DataTable selectdata(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = connection;


            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }


            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        //method to insert, update and delete data from database
        public void excuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = connection;
            if (param != null)
            {

                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

        }*/
    }
}
