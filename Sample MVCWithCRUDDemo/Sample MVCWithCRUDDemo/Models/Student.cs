using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_MVCWithCRUDDemo.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String StudentName { get; set; }
        public String MobileNumber { get; set; }
        public String EmailId { get; set; }
    }
}