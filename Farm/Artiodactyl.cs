using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public abstract class Artiodactyl : Animal
    {
        public Artiodactyl(Gender gender, int age, string name) 
            : base(gender, age) 
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
        }

        protected string Name { get; set; }
    }
}
