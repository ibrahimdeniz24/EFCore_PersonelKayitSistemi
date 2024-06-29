using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_20240505.Entities
{
    internal class Student
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string TCKNO { get; set; }

        public Department Department { get; set; }

        public int DepartmentID { get; set; }

        public Gender Gender { get; set; }

        public int GenderID { get; set; }


    }
}
