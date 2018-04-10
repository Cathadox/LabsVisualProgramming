using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Equation
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public char Operation { get; set; }
        public int result { get; set; }
        public Equation() { }
        private void getRandom()
        {
            Random r = new Random();
            firstNumber = r.Next(1, 10);
            secondNumber = r.Next(1, 10);

        }

        public void Randomize()
        {
            Random r = new Random();
            int k;

            getRandom();
            k = r.Next(1, 5);
            if (k == 1)
            {
                Operation = '/';
                while (firstNumber % secondNumber != 0)
                                getRandom();
                result = firstNumber / secondNumber;
            }
            if (k == 2)
            {
                Operation = '*';
                result = firstNumber * secondNumber;
            }

            if (k == 3)
            {
                Operation = '-';
                while (firstNumber - secondNumber <= 0)
                    getRandom();
                result = firstNumber - secondNumber;
            }
            if (k == 4)
            {
                Operation = '+';
                result = firstNumber + secondNumber;
            }


        }



    }
}
