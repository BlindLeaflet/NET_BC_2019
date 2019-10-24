using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BasePlayer:IPlayer
    {
        /// <summary>
        /// 
        /// </summary>
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;
        
        public BasePlayer()
        {
            Name = GetName();
        }
        public abstract string GetName();
        public abstract int GuessNumber();
        /// <summary>
        /// Metodes apraksts
        /// </summary>
        /// <param name="number">Parametra number apraksts</param>
        /// <returns>Ko metode atgriež?</returns>
        public virtual bool IsNumberGuessed(int number)
        {
            // 1. Checks and returns bool result if ‘number’ is equal ‘CurrentGuess’
            if (number > CurrentGuess)
            {
                Console.WriteLine($"{CurrentGuess} is less then number!");
                NextGuess = 1;
            }
            else if (number < CurrentGuess)
            {
                Console.WriteLine($"{CurrentGuess} is greater then number!");
                NextGuess = -1;
            }

            return number == CurrentGuess;
        }

    }
}
