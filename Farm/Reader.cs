using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public static class Reader
    {
        public static int GetAnswerInt()
        {
            int result;

            if (!int.TryParse(Console.ReadLine(), out result) || result == 0)
            {
                Console.Clear();
                Console.WriteLine("Enter an integer.");
                GetAnswerInt();
                return result;
            }
            else
            {
                Console.Clear();
                int reslult = Convert.ToInt32(result);
                return result;
            }
        }
    }
}
