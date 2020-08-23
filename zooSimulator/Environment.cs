using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
    public class Environment
    {
        protected WeatherType weather;
        protected int days;
        protected List<Species> ecosystem;

        protected WeatherType Weather { get => weather; set => weather = value; }
        protected int Days { get => days; set => days = value; }
        protected List<Species> Ecosystem { get => ecosystem; set => ecosystem = value; }

        public void NextDay()
        {
        }

        public List<Species> Select<T>() where T : Species
        {
            return null;
        }

        public void Eliminate(double threshold)
        {

        }

        public void ChangeWeather()
        {

        }

        public void Hunt()
        {

        }

        public void Feed()
        {

        }

        public void Spawn<T>(int quantity) where T : Species, new()
        {
            
        }



    }
}
