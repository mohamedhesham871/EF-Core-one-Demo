using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_one__Demo.Data
{
    public class Employee
    {
        public int  Id { get; set; }// ID or class+ID  => primary key By Default
        public required string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
