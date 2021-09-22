using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjResidence
{
    class Resident
    {
        private int r_ID;
        private string r_Name, r_Surname, r_Email, r_Cell, r_Year;

        public int R_ID { get => r_ID; set => r_ID = value; }
        public string R_Name { get => r_Name; set => r_Name = value; }
        public string R_Surname { get => r_Surname; set => r_Surname = value; }
        public string R_Email { get => r_Email; set => r_Email = value; }
        public string R_Cell { get => r_Cell; set => r_Cell = value; }
        public string R_Year { get => r_Year; set => r_Year = value; }

        public Resident(int res_ID, string res_Name, string res_Surname, string res_Email, string res_Cell, string res_Year)
        {
            R_ID = res_ID;
            R_Name = res_Name;
            R_Surname = res_Surname;
            R_Email = res_Email;
            R_Cell = res_Cell;
            R_Year = res_Year;
        }

    }
}
