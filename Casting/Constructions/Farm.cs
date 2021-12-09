using System;

namespace colony_builder.Casting
{
    public class Farm : Actor
    {
        public Farm(Point position)
        {
            SetImage(Constants.FARM_IMG_FILEPATH);
            SetPosition(position);  
            SetWidth(Constants.FARM_WIDTH);
            SetHeight(Constants.FARM_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
