using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public enum FeatherColor
    {
        White,
        Grey,
    }

    public abstract class Bird : Animal
    {
        public Bird(Gender gender, int age, FeatherColor featherColor) 
            : base(gender, age)
        {
            this.Gender = gender;
            this.Age = age;
            this.FeatherColor = featherColor;
        }

        protected FeatherColor FeatherColor { get; set; }
    }
}
