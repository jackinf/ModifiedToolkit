using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLToolkit.Mapping.CustomObjects
{
    public class CourseEntityAttributes : Hstore
    {
        public string code { get; set; }
        public string description { get; set; }
    }
}
