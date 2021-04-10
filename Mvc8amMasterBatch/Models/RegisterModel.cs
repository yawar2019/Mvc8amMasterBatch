using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc8amMasterBatch.Models
{
    public class RegisterModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Must Not Be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Must Not Be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and Cpwd Should be Same")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "EmailId Must Not Be Empty")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        
        [Range(10,40,ErrorMessage ="Age should be btw 10-40")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address Must Not Be Empty")]
        [StringLength(20,ErrorMessage ="max 20 character")]
        public string Address { get; set; }
    }
}