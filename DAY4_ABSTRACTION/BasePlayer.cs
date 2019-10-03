using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    abstract class BasePlayer:IPlayer
    {
        String Name;
        int CurrentGuess;
        public abstract bool isNumberGuessed(int number);

        public abstract string GetName();
        public abstract int GuessNumber();
        
    }
}
