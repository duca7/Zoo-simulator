using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    public class Wolf : Animal, IHuntable, IWeatherAffectable
    {
        public void AffectTo(WeatherType weather)
        {
            throw new NotImplementedException();
        }

        public void Hunt(Environment ev)
        {
            throw new NotImplementedException();
        }
    }
}
