using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<Student> st = new List<Student>()
        {
            new Student () { rollNo = 1, Name = "ABC" },
            new Student () { rollNo = 2, Name = "XYZ" }
        };
        
        // GET api/values
        public IEnumerable<Student> Get()
        {
            return st;
        }

        // GET api/values/5
        public IEnumerable<Student> Get(int id)
        {
            yield return st.First(student => student.rollNo == id);
        }

        // POST api/values
        public IEnumerable<Student> Post([FromBody] Student s)
        {
            st.Add(s);
            return st;
        }

        // PUT api/values/5
        public IEnumerable<Student> Put(int id, [FromBody]Student s)
        {
            Student s1 = st.First(student => student.rollNo == id);
            s1.rollNo = s.rollNo;
            s1.Name = s.Name;
            return st;
        }

        // DELETE api/values/5
        public IEnumerable<Student> Delete(int id)
        {
            Student s = st.First(student => student.rollNo == id); 
            st.Remove(s);
            return st;
        }
    }
}
