using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employmentManagement
{
    public class Employe
    {
        public DateTime JoiningDate { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public int Id { get; set; }

        public DateTime ModifiedTime { get; set; }
        public int Salary { get; set; }

    }
}
