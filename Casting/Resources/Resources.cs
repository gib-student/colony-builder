using System;

namespace colony_builder.Casting
{
    public class Resources : Actor
    {
        private int _foodCount;
        private int _woodCount;
        private int _stoneCount;
        private int _goldCount;

        public Resources()
        {
            SetPosition(new Point(Constants.RESOURCES_X, Constants.RESOURCES_Y));
            _foodCount = Constants.INITIAL_FOOD;
            _woodCount = Constants.INITIAL_WOOD;
            _stoneCount = Constants.INITIAL_STONE;
            _goldCount = Constants.INITIAL_GOLD;
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }

        public void UpdateResourcesText()
        {
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }
    }
}
