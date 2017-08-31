using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.IO;
using System.ComponentModel;
namespace MyLibrary
{
    public class myLibrary
    {
        public void MyProgram(string fileName,string data)
        {
            FileIOPermission permission_obj1 = new FileIOPermission(FileIOPermissionAccess.Read, @"C:\");
            FileIOPermission permission_obj2 = new FileIOPermission(FileIOPermissionAccess.Write, @"D:\");
            permission_obj1.Demand();
            permission_obj2.Demand();
            try
            {
                StreamWriter writer = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate));
                writer.WriteLine(data);
                writer.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void MyProgramRead(string fileName)
        {
            FileIOPermission permission_obj1 = new FileIOPermission(FileIOPermissionAccess.Write, @"C:\");
            FileIOPermission permission_obj2 = new FileIOPermission(FileIOPermissionAccess.Read, @"D:\");
            permission_obj1.Demand();
            permission_obj2.Demand();
            try
            {
                StreamReader reader = new StreamReader(new FileStream(fileName, FileMode.Open));
                //Console.WriteLine("hiiii");
                Console.WriteLine(reader.ReadLine());
                reader.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
