using Sample_MVCWithCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample_MVCWithCRUDDemo.DbConnent
{
    public class DbFile : DbContext
    {
        public DbSet<Student> student { get; set; }
    }
}