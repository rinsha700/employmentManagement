using employmentManagement.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employmentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
          Employe employe= helper.ReadDetails();
            helper.FileWrite(employe);
        }
    }
}
