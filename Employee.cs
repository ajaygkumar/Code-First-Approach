using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_Approach
{
    public class Employee
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int salary { get; set; }
        public Department Department { get; set; }
    }
}