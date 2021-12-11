using System;

namespace colony_builder.Casting
{
    public class GoldCount : Actor
    {
        Resources _resources;
        int _goldCount;

        public GoldCount(Resources resources)
        {
            _resources = resources;
            SetPosition(new Point(Constants.GOLD_COUNT_TEXT_X, 
                Constants.RESOURCES_COUNT_TEXT_Y));
            Update();
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            _goldCount = 
                (int)_resources.GetResourceCount(Constants.GOLD_TEXT);
            SetText(_goldCount.ToString());
        }
    }
}
