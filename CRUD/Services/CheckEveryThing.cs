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
            return acc.All(char.IsNumber);
        }

        public bool CheckYearofBirth(string year)
        {
            return Regex.IsMatch(year, @"[^\d+$]");
        }

        public bool checkMK(string Pass)
        {
            if (Pass.Length>3)
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