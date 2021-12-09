using System;

namespace colony_builder
{
    public class Resources
    {
        private double _foodCount;
        private double _woodCount;
        private double _stoneCount;
        private double _goldCount;

        private const double _foodProducedPerVillager  = 2;
        private const double _woodProducedPerVillager  = 2;
        private const double _stoneProducedPerVillager = 2;
        private const double _foodDepletedPerVillager   = 1;

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

        public void AddResources(string resource, int newResources)
        {
            switch (resource)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    SetFoodCount(_foodCount + (double)newResources);
                    break;
                case Constants.WOOD_ACTIONBAR_TEXT:
                    SetWoodCount(_woodCount + (double)newResources);
                    break;
                case Constants.STONE_ACTIONBAR_TEXT:
                    SetStoneCount(_stoneCount + (double)newResources);
                    break;
                case Constants.GOLD_TEXT:
                    SetGoldCount(_goldCount + (double)newResources);
                    break;
                default:
                    break;
            }
        }

        public void TakeAwayFood(int foodToDestroy)
        {
            _foodCount = _foodCount - (double)foodToDestroy;
        }

        private void SetResourceCount(string resource, int newCount)
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

        private void SetFoodCount(double newFood)
        {
            _foodCount = newFood;
        }

        private int GetFoodCount()
        {
            return (int)_foodCount;
        }

        private void SetWoodCount(double woodCount)
        {
            _woodCount = woodCount;
        }

        private int GetWoodCount()
        {
            return (int)_woodCount;
        }

        private void SetStoneCount(double stoneCount)
        {
            _stoneCount = stoneCount;
        }

        private int GetStoneCount()
        {
            return (int)_stoneCount;
        }

        private void SetGoldCount(double goldCount)
        {
            _goldCount = goldCount;
        }

        private int GetGoldCount()
        {
            return (int)_goldCount;
        }

        public int GetFoodProduced(int employedOnFood)
        {
            return (int)_foodProducedPerVillager * employedOnFood;
        }

        public int GetWoodProduced(int employedOnWood)
        {
            return (int)_woodProducedPerVillager * employedOnWood;
        }

        public int GetStoneProduced(int employedOnStone)
        {
            return (int)_stoneProducedPerVillager * employedOnStone;
        }

        public int GetHunger(int numVillagers)
        {
            return (int)_foodDepletedPerVillager * numVillagers;
        }
    }
}
