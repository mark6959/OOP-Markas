using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitNavnAflevering
{
    internal class Grade
    {
        private string _name;
        private int _point;
        public Grade(string name, int point)
        {
            _name = name;
            _point = point;
        }
        public string getName() { return _name; }
        public int getPoint() { return _point;
            }
    }
}
