using System;

namespace colony_builder.Casting
{
    public class ResourcesText : Actor
    {
        private int _foodCount;
        private int _woodCount;
        private int _stoneCount;
        private int _goldCount;

        public ResourcesText()
        {
            SetPosition(new Point(Constants.RESOURCES_X, Constants.RESOURCES_Y));
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }

        public void UpdateResourcesText()
        {
            SetText($"{_foodCount}      {_woodCount}      {_stoneCount}      {_goldCount}");
        }

        public override void DoAction()
        {
            
        }
    }
}
