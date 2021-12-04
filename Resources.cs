using System;

namespace colony_builder
{
    public class Resources
    {
        private int _foodCount;
        private int _woodCount;
        private int _stoneCount;
        private int _goldCount;

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
    }
}
