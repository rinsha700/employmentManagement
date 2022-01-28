using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employmentManagement.util
{
    public class Helper
    {
        public Employe ReadDetails()
        {
            Employe newEmploye=new Employe();
            Console.WriteLine("Enter your Name:");
            newEmploye.Name = Console.ReadLine();
            Console.WriteLine("Enter your ID:");
            newEmploye.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Salary:");
            newEmploye.Salary = Convert.ToInt32(Console.ReadLine());
            newEmploye.ModifiedTime = DateTime.Now;

            return newEmploye;

        }
        public void FileWrite(Employe employe)
        {
            StreamWriter st = new StreamWriter(@"C:\Users\SH-PKD-007\source\repos\employmentManagement\static_files\" + employe.Name+".txt");
            st.WriteLine("Employe Name:"+employe.Name);
            st.WriteLine("Employe ID:" + employe.Id);
        }
    }
}
