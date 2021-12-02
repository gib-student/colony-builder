using System;

namespace colony_builder
{
    public static class Resources
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
            if (resource == Constants.FOOD_ACTIONBAR_TEXT)
            {
                return GetFoodCount();
            }
            else if (resource == Constants.WOOD_ACTIONBAR_TEXT)
            {
                return GetWoodCount();
            }
            else if (resource == Constants.STONE_ACTIONBAR_TEXT)
            {
                return GetStoneCount();
            }
            else if (resource == Constants.GOLD_TEXT)
            {
                return GetGoldCount();
            }
            return -1;
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
