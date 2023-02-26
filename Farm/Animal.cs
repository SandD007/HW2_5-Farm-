using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum Gender
    {
        Male,
        Famele,
    }

    public abstract class Animal
    {
        public Animal(Gender gender, int age)
        {
            this.Age = age;
            this.Gender = gender;
        }

        protected int Age { get; set; }

        protected Gender Gender { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine("I am " + this.Gender + ", " + this.Age + " years old.");
        }

        public int GetAge()
        {
            return this.Age;
        }
    }
}
