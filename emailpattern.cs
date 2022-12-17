using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    public class emailpattern
    {
        public static string regexrule = "^[a-z]{3,8}[@]{1}[a-z]{3,8}[.]{1}[a-z]{3}";
        public bool validemail(string validemail)
        {
            return Regex.IsMatch(validemail, regexrule);
        }
    }
}
