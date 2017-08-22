using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class IDisposableDemo : IDisposable
    {
        public StreamWriter writer;
        public StreamReader reader;

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }

            if (writer != null)
            {
                writer.Dispose();
                Console.WriteLine("Space alloted for StreamWriter deallocated");
            }

            if (reader != null)
            {
                writer.Dispose();
                Console.WriteLine("Space alloted for StreamReader deallocated");
            }
        }

        public void FileIO()
        {
            writer = new StreamWriter(new FileStream(@"SampleFile.txt", FileMode.OpenOrCreate));
            writer.WriteLine("hi");
            writer.WriteLine("hello");
            writer.Close();
            
            reader = File.OpenText(@"SampleFile.txt");
            String temp;
            Console.WriteLine("Contents of the File : ");
            while ((temp = reader.ReadLine()) != null)
            {
                Console.WriteLine(temp);
            }
            
            Console.WriteLine("\nAfter calling Dispose method: ");
            Dispose();
        }
    }
}
