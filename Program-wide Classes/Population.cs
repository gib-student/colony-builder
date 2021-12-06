using System;

namespace colony_builder
{
    public class Population
    {
        private int _population;
        
        public Population()
        {
            _population = Constants.POP_INITIAL;
        }

        public int GetPopulation()
        {
            return _population;
        }

        public void SetPoplation(int newPopCount)
        {
            _population = newPopCount;
        }
    }
}
