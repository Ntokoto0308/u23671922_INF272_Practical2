using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23671922_INF272_Practical2.Models
{
    public class Person
    {
        [Display(Name = "Student number ")]
        public string Student_Number { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Surname ")]
        public string Surname { get; set; }

        [Display(Name = "Email address ")]
        public string Email_Address { get; set; }

        [Display(Name = "Link to personal page ")]

        public string myLink { get; set; }
    }
}