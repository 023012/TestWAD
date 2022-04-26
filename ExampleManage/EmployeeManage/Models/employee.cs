using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManage.Models
{
    public class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}