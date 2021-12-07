using System;

namespace colony_builder
{
    public class Population
    {
        private int _populationCount;
        private const double _populationGrowthRate = 1.001;
        
        public Population()
        {
            _populationCount = Constants.POP_INITIAL;
        }

        public int GetPopulation()
        {
            return _populationCount;
        }

        public void SetPoplation(int newPopCount)
        {
            _populationCount = newPopCount;
        }

        public void HaveChildren()
        {
            double newPopCount = _populationCount + (_populationCount * _populationGrowthRate);
            _populationCount = (int)newPopCount;
        }
    }
}
