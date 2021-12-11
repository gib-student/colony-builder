using System;

namespace colony_builder.Casting
{
    public class StoneCount : Actor
    {
        Resources _resources;
        int _stoneCount;

        public StoneCount(Resources resources)
        {
            _resources = resources;
            SetPosition(new Point(Constants.STONE_COUNT_TEXT_X, 
                Constants.RESOURCES_COUNT_TEXT_Y));
            Update();
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            _stoneCount = 
                (int)_resources.GetResourceCount(Constants.STONE_ACTIONBAR_TEXT);
            SetText(_stoneCount.ToString());
        }
    }
}
