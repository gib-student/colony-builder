using System;

namespace colony_builder.Logic
{
    public class ResourceRates
    {
        private const double _foodProductionRatePerVillager  = 0.001;
        private const double _woodProductionRatePerVillager  = 0.0005;
        private const double _stoneProductionRatePerVillager = 0.0005;
        private const double _foodDepletionRatePerVillager   = .00001;


        public double GetFoodProductionRate(int employedOnFood)
        {
            return _foodProductionRatePerVillager * employedOnFood;
        }

        public double GetWoodProductionRate(int employedOnWood)
        {
            return _woodProductionRatePerVillager * employedOnWood;
        }

        public double GetStoneProductionRate(int employedOnStone)
        {
            return _stoneProductionRatePerVillager * employedOnStone;
        }

        public double GetHungerRate(int numVillagers)
        {
            return _foodDepletionRatePerVillager * numVillagers;
        }
    }
}
