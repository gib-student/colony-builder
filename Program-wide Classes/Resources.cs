using System;

namespace colony_builder
{
    public class Resources
    {
        private int _foodCount;
        private int _woodCount;
        private int _stoneCount;
        private int _goldCount;

        private const double _foodProductionRatePerVillager  = 0.004;
        private const double _woodProductionRatePerVillager  = 0.003;
        private const double _stoneProductionRatePerVillager = 0.003;
        private const double _foodDepletionRatePerVillager   = -.001;

        public Resources()
        {
            _foodCount = Constants.INITIAL_FOOD;
            _woodCount = Constants.INITIAL_WOOD;
            _stoneCount = Constants.INITIAL_STONE;
            _goldCount = Constants.INITIAL_GOLD;
        }

        public int GetResourceCount(string resource)
        {
            switch (resource)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    return GetFoodCount();
                case Constants.WOOD_ACTIONBAR_TEXT:
                    return GetWoodCount();
                case Constants.STONE_ACTIONBAR_TEXT:
                    return GetStoneCount();
                case Constants.GOLD_TEXT:
                    return GetGoldCount();
                default:
                    return Constants.ERROR;
            }
        }

        public void SetResourceCount(string resource, int newCount)
        {
            switch (resource)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    SetFoodCount(newCount);
                    break;
                case Constants.WOOD_ACTIONBAR_TEXT:
                    SetWoodCount(newCount);
                    break;
                case Constants.STONE_ACTIONBAR_TEXT:
                    SetStoneCount(newCount);
                    break;
                case Constants.GOLD_TEXT:
                    SetGoldCount(newCount);
                    break;
                default:
                    break;
            }
        }

        private void SetFoodCount(int foodCount)
        {
            _foodCount = foodCount;
        }

        private int GetFoodCount()
        {
            return _foodCount;
        }

        private void SetWoodCount(int woodCount)
        {
            _woodCount = woodCount;
        }

        private int GetWoodCount()
        {
            return _woodCount;
        }

        private void SetStoneCount(int stoneCount)
        {
            _stoneCount = stoneCount;
        }

        private int GetStoneCount()
        {
            return _stoneCount;
        }

        private void SetGoldCount(int goldCount)
        {
            _goldCount = goldCount;
        }

        private int GetGoldCount()
        {
            return _goldCount;
        }

        public double GetFoodProductionRate(int employedOnFood)
        {
            return _foodProductionRatePerVillager * (double)employedOnFood;
        }

        public double GetWoodProductionRate(int employedOnWood)
        {
            return _woodProductionRatePerVillager * (double)employedOnWood;
        }

        public double GetStoneProductionRate(int employedOnStone)
        {
            return _stoneProductionRatePerVillager * (double)employedOnStone;
        }

        public double GetHungerRate(int numVillagers)
        {
            return _foodDepletionRatePerVillager * (double)numVillagers;
        }
    }
}
