using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    public class Grass: Plant, IWeatherAffectable
    {
        public void AffectTo(WeatherType weather)
        {
            throw new NotImplementedException();
        }

        public override void Breed(Environment ev)
        {
            throw new NotImplementedException();
        }

        public override void Die(Environment ev)
        {
            throw new NotImplementedException();
        }
    }
}
