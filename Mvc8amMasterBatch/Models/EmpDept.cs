using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc8amMasterBatch.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> listemp { get; set; } 
        public List<DepartmentModel> listdept { get; set; } 
    }
}