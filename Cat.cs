using System;

namespace Pets

{
    class Cat : Pet

    {

        public Cat(string Name, string Owner, double Weight) : base("Cat", Name, Owner, Weight)

        {
            weight = Weight;
            owner = Owner;
            name = Name;

        }

        public string meow(int count)

        {

            string meow = "";
            int i;
            for (i = 0; i < count; i++)

            {

                meow += "meow.";

            }

            return meow;
        }
    }
}
