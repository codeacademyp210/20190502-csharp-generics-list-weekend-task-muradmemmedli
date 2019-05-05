using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model
{
    public class Employee : User
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public int Id { get; set; }


    }
}
