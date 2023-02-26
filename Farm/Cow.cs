using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum BreedOfCow
    {
        Jersey,
        Guernsey,
        Ayrshire,
    }

    public class Cow : Artiodactyl
    {
        public Cow(Gender gender, int age, string name, BreedOfCow breedOfCow) 
            : base(gender, age, name)
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
            this.BreedOfCow = breedOfCow;
        }

        private BreedOfCow BreedOfCow { get; set; }

        public override void Introduce()
        {
            Console.WriteLine("Cow " + this.Name + ", " + this.BreedOfCow + " breed, " + this.Age + " years old.");
        }
    }
}
