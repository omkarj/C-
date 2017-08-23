using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoDatabaseApplication
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        public string sqlQuery = null;
        private string conString = @"Data Source=OMKAR-JV;Initial Catalog = DemoDatabase; Integrated Security = True; Pooling=False";

        public SqlHelper()
        {
            sqlConnection = new SqlConnection(conString);
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
                Console.WriteLine("Connection is open");
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand.ExecuteReader();
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
        }

        public string ExecuteScalar(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            sqlDataAdapter.Fill(ds, "StudentTable");
            return ds.Tables[0];
        }


        public void update(int rollNo, string sName)
        {
            var ds = new DataSet();
            sqlQuery = "select * from [Table]";
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(ds, "StudentTable");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = rollNo;
            dt.Rows[0][1] = sName;
            sqlDataAdapter.Update(dt);
        }

        public void updateRollNo(int oldRollNo, int newRollNo)
        {
            int i = 0;
            var ds = new DataSet();
            sqlQuery = "select * from [Table]";
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(ds, "StudentTable");
            DataTable dt = ds.Tables[0];
            i = dt.Select().Length - 1;
            while (i >= 0)
            {
                if (Convert.ToInt16(dt.Rows[i][0]) == oldRollNo)
                {
                    dt.Rows[i][0] = newRollNo;
                    sqlDataAdapter.Update(dt);
                    Console.WriteLine("Roll No updated successfully");
                    break;
                }
                i--;
            }
        
        }
    }
}
