using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public static class Farm
    {
        private static Animal[] animalsInFarm =
        {
            new Chicken(Gender.Famele, 2, FeatherColor.White, BreedOfСhicken.PlymouthRockChicken),
            new Chicken(Gender.Famele, 1, FeatherColor.Grey, BreedOfСhicken.FoxyChick),
            new Chicken(Gender.Famele, 4, FeatherColor.White, BreedOfСhicken.RhodeIslandRed),
            new Chicken(Gender.Male, 3, FeatherColor.White, BreedOfСhicken.RhodeIslandRed),

            new Goose(Gender.Famele, 1, FeatherColor.Grey, BreedOfGoose.AfricanGoose),
            new Goose(Gender.Famele, 2, FeatherColor.White, BreedOfGoose.EmbdenGoose),
            new Goose(Gender.Famele, 2, FeatherColor.White, BreedOfGoose.ToulouseGoose),
            new Goose(Gender.Male, 4, FeatherColor.White, BreedOfGoose.ToulouseGoose),

            new Cow(Gender.Famele, 6, "Natasha", BreedOfCow.Ayrshire),
            new Cow(Gender.Famele, 5, "Liza", BreedOfCow.Jersey),
            new Cow(Gender.Male, 3, "Maksim", BreedOfCow.Guernsey),

            new Goat(Gender.Famele, 5, "Karina", BreedOfGoat.AlpineGoat),
            new Goat(Gender.Famele, 4, "Valentina", BreedOfGoat.SaanenGoat),
            new Goat(Gender.Male, 5, "Vania", BreedOfGoat.LaManchaGoat),
        };

        public static Animal[] MyFarm()
        {
            return animalsInFarm;
        }
    }
}
