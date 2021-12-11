using System;

namespace colony_builder
{
    public class Population
    {
        private double _populationCount;
        private const double _populationGrowthRate = 1.009;

        EmployedVillagers _employedVillagers;
        
        public Population(EmployedVillagers employedVillagers)
        {
            _populationCount = Constants.POP_INITIAL;
            _employedVillagers = employedVillagers;
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
            int intPopCount = (int)_populationCount;
            double newPopCount = _populationCount * _populationGrowthRate;
            int intNewPopCount = (int)newPopCount;
            int dPopCount = intNewPopCount - intPopCount;
            SetPoplation(newPopCount);
            // Add an unemployed villager when the population increases
            if (dPopCount >= 1)
            {
                _employedVillagers.IncrementUnemployed();
            }
        }
    }
}
