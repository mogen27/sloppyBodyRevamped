using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sloppyBody
{
    public class vector
    {
        public double x;
        public double y;


        public vector(double ax, double ay)
        {
            x = ax;
            y = ay;
        }

        public vector()
        {
        }


        static public double mag(vector vector)
        {
            double mag;
            mag = Math.Sqrt(Math.Pow(vector.x, 2) + Math.Pow(vector.y, 2));
            return mag;
        }

        static public vector normalize(vector vector)
        {
            vector normalized = new vector();
            normalized.x = vector.x / mag(vector);
            normalized.y = vector.y / mag(vector);
            return normalized;
        }

        static public vector add(vector vector1, vector vector2)
        {
            vector added = new vector();
            added.x = vector1.x + vector2.x;
            added.y = vector1.y + vector2.y;
            return added;
        }


        static public vector sub(vector vector1, vector vector2)
        {
            vector subbed = new vector();
            subbed.x = vector1.x - vector2.x;
            subbed.y = vector1.y - vector2.y;
            return subbed;
        }


        static public double multVector(vector vector1, vector vector2)
        {
            double multed;
            multed = vector1.x * vector2.x + vector1.y * vector2.y;
            return multed;
        }

        static public vector multNum(vector vector1, double num)
        {
            vector multed = new vector();
            multed.x = vector1.x * num;
            multed.y = vector1.y * num;
            return multed;
        }

        static public vector divNum(vector vector1, double num)
        {
            vector div = new vector();
            div.x = vector1.x / num;
            div.y = vector1.y / num;
            return div;
        }



    }
}
