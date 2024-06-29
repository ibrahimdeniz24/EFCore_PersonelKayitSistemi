using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_20240505.Entities
{
    internal class Department
    {
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public List<Student> Students { get; set; }



    }
}
