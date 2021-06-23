using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sloppyBody
{
    public class massPoint
    {

        public vector pos;
        public vector vel;
        public vector force = new vector(0, 0);
        public double mass;

        

        public List<vector> naybersIndex = new List<vector>();

        //public List<spring> springs = new List<spring>();
        

        /*public void addSprings()
        {
            for(int i = 0; i < naybersIndex.Count; i++)
            {
                //springs.Add(new spring(pos, F));
                
            }
        }

        public void calcSpringForce(massPoint[,] b)
        {
            for (int i = 0; i < naybersIndex.Count; i++)
            {
                massPoint tempBlock = b[Convert.ToInt32(naybersIndex[i].x), Convert.ToInt32(naybersIndex[i].y)];

            }
        }
        */



        // HUR KAN JAG FÅ BLOCK-ARRAYEN HIT?? BEHÖVS FÖR ATT GÖRA SPRINGS

        public massPoint(vector apos, vector avel, double amass)
        {
            pos = apos;
            vel = avel;
            mass = amass;
        }


        public void updatePos()
        {
            vel = vector.add(vel,force);
            pos = vector.add(pos, vel);
            force = new vector(0, 0);
        }



        //varje masspunkt ska ha fjädrar till sina grannar.
       //lista med spring's

        //tar bort felaktiga grannar hos varje masspoint! Blir kallad från form1 fillBlockfunktionen
        public void fixList(int count)
        {

            for (int i = 0; i < naybersIndex.Count; i++)
            {
                if (naybersIndex[i].x < 0 || naybersIndex[i].x >= count || naybersIndex[i].y < 0 || naybersIndex[i].y >= count)
                {
                    naybersIndex.RemoveAt(i);
                    i--;
                    
                }

            }
        }

      
    }
}
