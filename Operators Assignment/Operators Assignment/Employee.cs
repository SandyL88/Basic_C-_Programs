using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //== operation
        public static bool operator == (Employee emp1, Employee emp2)
        {
            //if emp1 and emp2 are null or emp1=emp2, Then true.
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            //if onle one is null, then its not equal.
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            return emp1.Id == emp2.Id;
        }

        //!= operator
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return !(emp2 == emp1);
        }

        //Equal
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee emp = (Employee) obj;
                return this.Id ==emp.Id;
            }
            return false;
        }
        //rewrite GetHashCode
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
