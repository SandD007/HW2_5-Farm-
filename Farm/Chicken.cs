using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum BreedOfСhicken
    {
        FoxyChick,
        PlymouthRockChicken,
        RhodeIslandRed,
    }

    public class Chicken : Bird
    {
        public Chicken(Gender gender, int age, FeatherColor featherColor, BreedOfСhicken breedOfСhicken) 
            : base(gender, age, featherColor)
        {
            this.Gender = gender;
            this.Age = age;
            this.FeatherColor = featherColor;
            this.BreedOfСhicken = breedOfСhicken;
        }

        private BreedOfСhicken BreedOfСhicken { get; set; }

        public override void Introduce()
        {
            Console.WriteLine("Chicken " + this.Gender + ", " + this.BreedOfСhicken + " breed, " + this.Age + " years old.");
        }
    }
}
