using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjResidence
{
    class Complaint
    {
        private int comp_ID, cat_ID, u_ID;
        private string comp_Status, comp_Desc;

        public int Comp_ID { get => comp_ID; set => comp_ID = value; }
        public int Cat_ID { get => cat_ID; set => cat_ID = value; }
        public int U_ID { get => u_ID; set => u_ID = value; }
        public string Comp_Status { get => comp_Status; set => comp_Status = value; }
        public string Comp_Desc { get => comp_Desc; set => comp_Desc = value; }

        public Complaint(int CompID, int CatID, int uID, string comp_Status, string comp_Desc)
        {
            Comp_ID = CompID;
            Cat_ID = CatID;
            U_ID = uID;
            Comp_Status = comp_Status;
            Comp_Desc = comp_Desc;
        }
    }
}
