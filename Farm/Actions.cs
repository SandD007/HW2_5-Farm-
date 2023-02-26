using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public static class Actions
    {
        private static Animal[] animals = SelectedAnimal();

        public static void FineByAge(int age)
        {
            int coincidenceIndex = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                if (age == animals[i].GetAge())
                {
                    animals[i].Introduce();
                    coincidenceIndex++;
                }
            }

            if (coincidenceIndex == 0)
            {
                Console.WriteLine("Unfortunately, it was not possible to find animals that are now " + age + " years old");
            }
        }

        public static void SendMessage()
        {
            Messenger.SendMessage(animals);
        }

        public static void SortByAge()
        {
            Array.Sort(animals, (p1, p2) => p1.GetAge().CompareTo(p2.GetAge()));
            Messenger.SendMessage(animals);
        }

        public static int CalculateAge()
        {
            int age = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                age += animals[i].GetAge();
            }

            return age;
        }

        private static Animal[] SelectedAnimal()
        {
            Animal[] animal = Selector.AnimalSelection(Reader.GetAnswerInt());
            return animal;
        } 
    }
}
