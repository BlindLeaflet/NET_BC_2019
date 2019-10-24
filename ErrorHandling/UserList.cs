using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            //pārbaudes
            //1.datums nedrīkst but nākotnē
            if (date>DateTime.Now)
            {
                throw new InputException("Birth date cannot be in the future.");
            }
            //2.datums nedrīkst būt mazāks par 01.01.1800
            if(date< new DateTime(1800,1,1))
            {
            throw new InputException("Birth date cannot be before 01.01.1800");
            }
            //3. pilnais vards nedrikst parsniegt 20 simbolus
            if (fullName.Length>20)
            {
                throw new InputException("Full name is too long");
            }

            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            //lietotaja pievienosana
            users.Add(user);

            Console.WriteLine($"User with age {user.Age()} added.");
        }

	

	}

}
    

