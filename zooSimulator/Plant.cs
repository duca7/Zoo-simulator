using System;
using System.Collections.Generic;
using System.Text;

namespace zooSimulator
{
     public abstract class Plant:Species
    {
        public override void Breed(Environment ev)
        {
            throw new NotFiniteNumberException();
        }
    }
}
