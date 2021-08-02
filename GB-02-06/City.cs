using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_02_06
{
    class City
    {
        string _name;

        public City(string name)
        {


            _name = name;

        }

        public string Title()
        {
            return _name;  
        }

    }
}
