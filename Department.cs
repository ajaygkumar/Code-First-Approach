﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_Approach
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}