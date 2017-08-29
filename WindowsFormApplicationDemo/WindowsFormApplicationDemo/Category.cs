using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormApplicationDemo;

namespace WinFormswithEFSample
{
    public class Category
    {
        private readonly ObservableListSource<Student> _students =
                new ObservableListSource<Student>();

        public int rollNo { get; set; }
        public string studentName { get; set; }
        public virtual ObservableListSource<Student> Students { get { return _students; } }
    }
}