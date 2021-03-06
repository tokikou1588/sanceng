using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Employee
    {
        [DisplayText]
        public string Name { get; set; }

        [DisplayText]
        public string Gender { get; set; }

        [DisplayText]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayText]
        public string Department { get; set; }
    }
}