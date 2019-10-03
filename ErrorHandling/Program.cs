using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList list = new UserList();
            // 1. cikliski vaicā pievienot lietotājus
            while (true)
            {
                //1.ievada vārdu
                string name = GetText();
                //2. ievada datumu (DateTime.TryParse)
                DateTime birthDate = GetDate();
                //1.3 Ievada dzimumu (Enum.TryParse)
                UserProfile.Genders gender = GetGender();
            }
        }
    }
}
