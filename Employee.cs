using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public abstract class Employee : Ipay
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public String LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDate}," +
                $" Hiring: {HiringDate}," +
                $" Is active: {IsActive}";
        }

    }

   
}
