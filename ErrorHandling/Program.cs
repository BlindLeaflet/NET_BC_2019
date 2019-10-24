using ConsoleHelpers;
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
            //Day3
            try
            {
                UserList list = new UserList();
                // 1. cikliski vaicā pievienot lietotājus
                while (true)
                {
                    try
                    {
                        //1.1.ievada vārdu
                        string name = ConsoleInput.GetText("Enter name: ");
                        //1.2. ievada datumu (DateTime.TryParse)
                        DateTime birthDate = ConsoleInput.GetDate("Enter birth date: ");
                        //1.3 Ievada dzimumu (Enum.TryParse)
                        UserProfile.Genders gender = GetGender();
                        //2.Izsauc lietotāja pievienošanu ar vērtībām augstāk
                        list.Add(name, gender, birthDate);
                        //3.ja neizdevas pievienot, attēlo kļūdu paziņojumu un sāk 1. soli no jauna.

                        Console.WriteLine("Add another? (Y/N)");
                        string input = Console.ReadLine().ToLower();
                        if (input == "n")
                        {
                            break;
                        }
                    }
                    catch (InputException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Unexpected error {ex.Message}");
            }
            
            Console.Read();
        }
        
        public static UserProfile.Genders GetGender()
        {
            Console.WriteLine("Enter Gender: ");
            string value = Console.ReadLine();

            if (UserProfile.Genders.TryParse(value, true, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value.");
                return GetGender();
            }
        }
    }
}
