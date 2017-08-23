using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoDatabaseApplication
{
    public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery;

        public Student()
        {
            sqlHelper = new SqlHelper();
        }

        public void GetData()
        {
            sqlQuery = "select * from [Table]";
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);
            Console.WriteLine("\nEntries in Student Table :");
            while (sqlReader.Read())
            {
                Console.WriteLine(string.Format("Roll Number : {0} & Student Name : {1}", sqlReader[0].ToString(), sqlReader[1].ToString()));
            }
            sqlReader.Close();
        }
        public void GetCount()
        {
            sqlQuery = "select count(RollNo) from [Table]";
            var count = sqlHelper.ExecuteScalar(sqlQuery);
            Console.WriteLine("Count : {0}", count);
        }
        public void SaveData()
        {
            Console.WriteLine("Enter Roll No : ");
            string rNo = Console.ReadLine();
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Marks : ");
            string marks = Console.ReadLine();
            Console.WriteLine("Enter Contact Number : ");
            string cNo = Console.ReadLine();
            sqlQuery = string.Format(@"insert into [Table] values ({0}, '{1}', {2}, '{3}')", rNo, name, marks, cNo) ;
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);
            sqlReader.Close();
        }

        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt = sqlHelper.GetDataSet(sqlQuery);
            foreach (DataRow  dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll Number : {0} & Student Name : {1}", dr[0].ToString(), dr[1].ToString()));
            }
            try
            {
                dt.WriteXml("StudentTable.xls");
                Console.WriteLine("\nStudentTable.xls File successfully created");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error in writing to StudentTable.xls File.\n" + e.Message);
            }
        }
        
        public void updateData()
        {
            sqlHelper.update(12, "jkl");
        }

        public void UpdateRollNoData()
        {
            Console.WriteLine("\nRecords before updation : ");
            GetData();
            sqlHelper.updateRollNo(5, 55);
            Console.WriteLine("\nRecords after updation : ");
            GetData();
        }
    }
}
