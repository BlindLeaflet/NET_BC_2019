using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class UserProfile
    {
        public enum Genders
        {
            Male,
            Female
        }
        public string FullName { get; set; }        
        public Genders Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public UserProfile(string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public int Age()
        {
            //calculate age using BirthDate
            var now = DateTime.Today;
            var age = now.Year - BirthDate.Year;
            if (BirthDate.Date > now.AddYears(-age)) 
            {
                age--;
            }
            return age;
        }
    }
}
