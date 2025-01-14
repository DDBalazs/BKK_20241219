using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKK_20241219
{
    internal class Jegyek
    {
        int vdb = 0;
        int vosszeg = 0;
        int tdb = 0;
        int tosszeg = 0;
        int ddb = 0;
        int dosszeg = 0;

        public int Vdb { get => vdb; set => vdb = value; }
        public int Vosszeg { get => vosszeg; set => vosszeg = value; }
        public int Tdb { get => tdb; set => tdb = value; }
        public int Tosszeg { get => tosszeg; set => tosszeg = value; }
        public int Ddb { get => ddb; set => ddb = value; }
        public int Dosszeg { get => dosszeg; set => dosszeg = value; }

        public Jegyek(string sor)
        {
            string[] dbok = sor.Split(';');
            vdb = int.Parse(dbok[0]);
            vosszeg = int.Parse(dbok[1]);
            tdb = int.Parse(dbok[2]);
            tosszeg = int.Parse(dbok[3]);
            ddb = int.Parse(dbok[4]);
            dosszeg = int.Parse(dbok[5]);

        }
        
        public int FizetendoSzamitas()
        {
            return vosszeg + tosszeg + dosszeg;
        }
    }
}
