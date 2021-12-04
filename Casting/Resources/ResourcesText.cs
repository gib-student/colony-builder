using System;

namespace colony_builder.Casting
{
    public class ResourcesText : Actor
    {
        Resources _resources;
        private int _foodCount;
        private int _woodCount;
        private int _stoneCount;
        private int _goldCount;

        public ResourcesText(Resources resources)
        {
            _resources = resources;
            UpdateResourcesValues();
            SetPosition(new Point(Constants.RESOURCES_X, Constants.RESOURCES_Y));
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }

        private void UpdateResourcesText()
        {
            UpdateResourcesValues();
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }

        private void UpdateResourcesValues()
        {
            _foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            _woodCount = _resources.GetResourceCount(Constants.WOOD_ACTIONBAR_TEXT);
            _stoneCount = _resources.GetResourceCount(Constants.STONE_ACTIONBAR_TEXT);
            _goldCount = _resources.GetResourceCount(Constants.GOLD_TEXT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            UpdateResourcesText();
        }
    }
}
