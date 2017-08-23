using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoDatabaseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                //student.SaveData();
                //student.updateData();
                student.UpdateRollNoData();
                //student.GetData();
                //student.GetCount();
                //student.getDataSet();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
