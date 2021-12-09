using System;

namespace colony_builder
{
    public class Population
    {
        private double _populationCount;
        private const double _populationGrowthRate = 1.0005;
        
        public Population()
        {
            _populationCount = Constants.POP_INITIAL;
        }

        public int GetPopulation()
        {
            return (int)_populationCount;
        }

        public void SetPoplation(double newPopCount)
        {
            _populationCount = newPopCount;
        }

        public void HaveChildren()
        {
            double newPopCount = _populationCount * _populationGrowthRate;
            SetPoplation(newPopCount);
        }
    }
}
