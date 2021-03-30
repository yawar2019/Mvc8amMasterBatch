using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc8amMasterBatch.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        [ScaffoldColumn(false)]
        public int EmpSalary { get; set; }

        public bool Status { get; set; }
    }
}