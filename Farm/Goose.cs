using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum BreedOfGoose
    {
        ToulouseGoose,
        AfricanGoose,
        EmbdenGoose,
    }

    public class Goose : Bird
    {
        public Goose(Gender gender, int age, FeatherColor featherColor, BreedOfGoose breedOfGoose) 
            : base(gender, age, featherColor)
        {
            this.Gender = gender;
            this.Age = age;
            this.FeatherColor = featherColor;
            this.BreedOfGoose = breedOfGoose;
        }

        private BreedOfGoose BreedOfGoose { get; set; }

        public override void Introduce()
        {
            Console.WriteLine("Goose " + this.Gender + ", " + this.BreedOfGoose + " breed, " + this.Age + " years old.");
        }
    }
}
