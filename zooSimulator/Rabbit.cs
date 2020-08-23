using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    public class Rabbit : Animal, IHuntable
    {
        public Rabbit()
        {
            breedingPriod = 5;
        }




        public void Hunt(Environment ev)
        {
            List<Species> food = ev.Select<Grass>();
            Random random = new Random();
            Grass selection = food[random.Next(0, food.Count)] as Grass;
            for (int i = 0; i < food.Count; i++)
            {

            }

        }
    }
}
