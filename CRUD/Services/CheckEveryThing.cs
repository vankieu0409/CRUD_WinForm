using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD.IServices
{
    public class CheckEveryThing:ICheck
    {
        public CheckEveryThing()
        {
            
        }

        public bool CheckAcc(string acc)
        {
            if (acc.Any(char.IsNumber))
            {
                if (acc.Any(char.IsDigit))
                {
                    return true;
                }
                
            }

            return false;
        }

        public bool CheckYearofBirth(string year)
        {
            if( Regex.IsMatch(year, @"[^\d+$]")==true)
            {
                return false;
            }

            return true;
        }

        public bool checkMK(string Pass)
        {
            if (Pass.Length>=3)
            {
                return true;
            }

            return false;
        }

        public bool checkNull(string text)
        {
            return string.IsNullOrWhiteSpace(text);

        }
    }
}