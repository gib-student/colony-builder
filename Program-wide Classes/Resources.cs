using System;

namespace colony_builder
{
    public class Resources
    {
        private double _foodCount;
        private double _woodCount;
        private double _stoneCount;
        private double _goldCount;

        private const double _foodProducedPerVillager  = 1.2;
        private const double _woodProducedPerVillager  = .1;
        private const double _stoneProducedPerVillager = .1;
        private const double _foodDepletedPerVillager   = .4;

        public Resources()
        {
            _foodCount = Constants.INITIAL_FOOD;
            _woodCount = Constants.INITIAL_WOOD;
            _stoneCount = Constants.INITIAL_STONE;
            _goldCount = Constants.INITIAL_GOLD;
        }

        public double GetResourceCount(string resource)
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

        public void AddResources(string resource, double newResources)
        {
            switch (resource)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    SetFoodCount(_foodCount + newResources);
                    break;
                case Constants.WOOD_ACTIONBAR_TEXT:
                    SetWoodCount(_woodCount + newResources);
                    break;
                case Constants.STONE_ACTIONBAR_TEXT:
                    SetStoneCount(_stoneCount + newResources);
                    break;
                case Constants.GOLD_TEXT:
                    // Don't allow gold to be changed for now
                    // SetGoldCount(_goldCount + (double)newResources);
                    break;
                default:
                    break;
            }
        }

        public void DestroyFood(double foodToDestroy)
        {
            _foodCount -= foodToDestroy;
        }

        public void DestroyWood(double woodToDestroy)
        {
            _woodCount -= woodToDestroy;
        }

        public void DestroyStone(double stoneToDestroy)
        {
            _stoneCount -= stoneToDestroy;
        }

        public void SetResourceCount(string resource, double newCount)
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

        private double GetFoodCount()
        {
            return _foodCount;
        }

        private void SetWoodCount(double woodCount)
        {
            _woodCount = woodCount;
        }

        private double GetWoodCount()
        {
            return _woodCount;
        }

        private void SetStoneCount(double stoneCount)
        {
            _stoneCount = stoneCount;
        }

        private double GetStoneCount()
        {
            return _stoneCount;
        }

        private void SetGoldCount(double goldCount)
        {
            _goldCount = goldCount;
        }

        private double GetGoldCount()
        {
            return _goldCount;
        }

        public double GetFoodProducedPerVillager()
        {
            return _foodProducedPerVillager;
        }

        public double GetWoodProducedPerVillager()
        {
            return _woodProducedPerVillager;
        }

        public double GetStoneProducedPerVillager()
        {
            return _stoneProducedPerVillager;
        }

        public double GetFoodDepletedPerVillager()
        {
            return _foodDepletedPerVillager;
        }
    }
}
