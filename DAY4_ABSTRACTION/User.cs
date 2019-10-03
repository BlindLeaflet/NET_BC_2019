using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class User:BasePlayer
    {
        //get name
        public override string GetName()
        {
            return "Name";
        }
        //guess number
        public override int GuessNumber()
        {
            return 0;
        }
        //is number guessed
        public override bool isNumberGuessed(int number)
        {
            return false;
        }
    }
}
