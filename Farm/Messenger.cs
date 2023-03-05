using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum ChoiseOfMessage
    {
        ChoiseOfQuantity,
        ChosieOfAge,
    }

    public static class Messenger
    {
        private const string CHOISEOFQUANTITY = "Enter the number of animals that will go to the vet today.";
        private const string CHOISEOFAGE = "Enter the age of the animals to sort.";

        public static void SendMessage(ChoiseOfMessage mes)
        {
            if (mes == ChoiseOfMessage.ChoiseOfQuantity)
            {
                Console.WriteLine(CHOISEOFQUANTITY);
                Console.WriteLine();
            }

            if (mes == ChoiseOfMessage.ChosieOfAge)
            {
                Console.WriteLine(CHOISEOFAGE);
            }
        }

        public static void SendMessage(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Introduce();
            }

            Console.WriteLine();
        }

        public static void SendCalculateAge(int age)
        {
            Console.WriteLine("Age of animals: " + age);
            Console.WriteLine();
        }
    }
}
