using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class GeneratedCode
    {
        public string checkCode(string id)
        {

            string Year = id.Substring(0, 4);
            int yr = Convert.ToInt32(Year);
            var CurrentYear = 2021;
            string month = id.Substring(4, 2);
            int mon = Convert.ToInt32(month);
            if (yr <= CurrentYear && mon <= 31)
            {
                return "true";

            }
            else
            {
                return "false";
            }

        }
        public string ValidateLength(string id)

        {
            if (id.Length == 6)
            {
                return "true";
            }

            else
            {
                return "false";
            }
           
        }

    }
}
