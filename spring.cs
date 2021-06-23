using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sloppyBody
{
    public class spring
    {

        public vector hostPos;
        public vector bPos; 

        public double k = 1;

        public double jmv;

        //damping-term?


        public spring(vector host, vector b)
        {
            hostPos = host;
            bPos = b;
        }




    }
}
