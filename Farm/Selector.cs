using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public static class Selector
    {
        private static Random random = new Random();
        private static Animal[] animalInFarm = Farm.MyFarm();
        private static int countOfAnimals = animalInFarm.Length;

        public static Animal[] AnimalSelection(int count)
        {
            Animal[] animals = new Animal[count];

            for (int i = 0; i < count; i++)
            {
                int rand = random.Next(1, countOfAnimals);
                animals[i] = animalInFarm[rand];
            }

            return animals;
        }
    }
}
