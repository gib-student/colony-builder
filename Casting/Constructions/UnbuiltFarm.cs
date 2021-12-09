using System;

namespace colony_builder.Casting
{
    public class UnbuiltFarm : Actor
    {
        public UnbuiltFarm(Point position)
        {
            SetImage(Constants.UNBUILT_FARM_IMG_FILEPATH);
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
