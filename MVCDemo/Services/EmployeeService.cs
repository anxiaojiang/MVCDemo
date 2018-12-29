using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Entity;

namespace MVCDemo.Services
{
    public class EmployeeService
    {
        //public Empolyee GetEmpolyee()
        //{
        //    using (CompanyEntities1 ef = new CompanyEntities1())
        //    {
        //        Empolyee result = ef.Empolyees.FirstOrDefault();
        //        return result;
        //    } 
        //}

        public List<Empolyee> GetEmpolyees()
        {
            using (CompanyEntities1 ef = new CompanyEntities1())
            {
                return ef.Empolyees.ToList();
            }
        }
    }
}