using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjResidence
{
    class Unit
    {
        private int unit_ID, r_ID;

        public int Unit_ID { get => unit_ID; set => unit_ID = value; }
        public int R_ID { get => r_ID; set => r_ID = value; }

        public Unit(int UnitID, int ResID)
        {
            Unit_ID = UnitID;
            R_ID = ResID;
        }
    }
}
