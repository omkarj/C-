using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class UsingDemo
    {
        public StreamWriter writer;
        public StreamReader reader;
        
        public void FileIO()
        {
            using (writer = new StreamWriter(new FileStream(@"SampleFile.txt", FileMode.OpenOrCreate)))
            {
                writer.WriteLine("hi");
                writer.WriteLine("hello");
                writer.Close();
            }
            //writer.WriteLine("This writer will not work");

            using (reader = File.OpenText(@"SampleFile.txt"))
            {
                String temp;
                Console.WriteLine("Contents of the File : ");
                while ((temp = reader.ReadLine()) != null)
                {
                    Console.WriteLine(temp);
                }
            }
            //reader.ReadLine();    //This writer will not work;
        }
    }
}
