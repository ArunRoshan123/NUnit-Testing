using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class GradeCalculator
    {
        public string GetGradeByPercentage(int percent)
        {
            if (percent >= 90 && percent <= 100)
                return "O";
            else if (percent >= 80 && percent <= 89)
                return "A+";
            else if (percent >= 70 && percent <= 79)
                return "A";
            else if (percent >= 60 && percent <= 69)
                return "B+";
            else if (percent >= 50 && percent <= 59)
                return "B";
            else if (percent <= 49)
                return "F";
            else 
                return "Invalid";
        }
    }
}
