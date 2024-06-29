using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_20240505.Entities
{
    internal class Gender
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }

        public List<Student> Students { get; set; }
    }
}
