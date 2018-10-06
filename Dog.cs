using System;

namespace Pets

{

    class Dog : Pet

    {
        public Dog(string Name, string Owner, double Weight) : base("Dog", Name, Owner, Weight)

        {
        
    		weight = Weight;
            owner = Owner;
            name = Name;
            

        }

        public string bark(int count)

        {

            int i;
            string bark = "";

            for (i = 0; i < count; i++)

            {

                bark += "bark!";

            }

            return bark;
        }
    }
}
