using System;

namespace Pets

{

    class Pet

    {

        public string type, name, owner;
        public double weight;

        public Pet(string Type, string Name, string Owner, double Weight)

        {
           
            weight = Weight;
            owner = Owner;
            name = Name;
            type = Type;

        }

        public string getTag()

        {

            string tag = "If Lost Call " + owner;
            return tag;

        }
    }
}
