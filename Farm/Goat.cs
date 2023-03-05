using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum BreedOfGoat
    {
        AlpineGoat,
        SaanenGoat,
        LaManchaGoat,
    }

    public class Goat : Artiodactyl
    {
        public Goat(Gender gender, int age, string name, BreedOfGoat breedOfGoat) 
            : base(gender, age, name)
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
            this.BreedOfGoat = breedOfGoat;
        }

        private BreedOfGoat BreedOfGoat { get; set; }

        public override void Introduce()
        {
            Console.WriteLine("Goat " + this.Name + ", " + this.BreedOfGoat + " breed, " + this.Age + " years old.");
        }
    }
}
