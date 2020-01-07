using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ExampleApp
{
    class MemberVO
    {
        public long No { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "No:"+No+", Name:"+Name+", Age:"+Age;
        }
    }


}
