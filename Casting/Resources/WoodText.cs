using System;

namespace colony_builder.Casting
{
    public class WoodCount : Actor
    {
        Resources _resources;
        int _woodCount;

        public WoodCount(Resources resources)
        {
            _resources = resources;
            SetPosition(new Point(Constants.WOOD_COUNT_TEXT_X, 
                Constants.RESOURCES_COUNT_TEXT_Y));
            Update();
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            _woodCount = 
                (int)_resources.GetResourceCount(Constants.WOOD_ACTIONBAR_TEXT);
            SetText(_woodCount.ToString());
        }
    }
}
