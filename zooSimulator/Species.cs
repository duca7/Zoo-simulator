using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    public abstract class Species
    {
        protected string id;
        protected string name;
        protected double heath;
        protected double length;
        protected double weight;
        protected GenderType gender;
        protected int age;
        protected int breedingPriod;

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected double Heath { get => heath; set => heath = value; }
        protected double Length { get => length; set => length = value; }
        protected double Weight { get => weight; set => weight = value; }
        protected GenderType Gender { get => gender; set => gender = value; }
        protected int Age { get => age; set => age = value; }
        protected int BreedingPriod { get => breedingPriod; set => breedingPriod = value; }


        public abstract void Breed(Environment ev);
        public abstract void Die(Environment ev);
    
    }

   
}
