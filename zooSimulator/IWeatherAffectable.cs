using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    interface IWeatherAffectable
    {
        void AffectTo (WeatherType weather);
    }
}
