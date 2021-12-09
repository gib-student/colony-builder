using System;

namespace colony_builder.Casting
{
    public class UnbuiltMine : Actor
    {
        public UnbuiltMine(Point position)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_MINE_IMG_FILEPATH);
            SetWidth(Constants.MINE_WIDTH);
            SetHeight(Constants.MINE_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
