using System;

namespace colony_builder.Casting
{
    public class UnbuiltMine : Actor
    {
        int _mineNum;

        public UnbuiltMine(Point position, int mineNum)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_MINE_IMG_FILEPATH);
            SetWidth(Constants.MINE_WIDTH);
            SetHeight(Constants.MINE_HEIGHT);
            SetHasActionIfPressed(true);
            _mineNum = mineNum;
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }

        public int GetMineNum()
        {
            return _mineNum;
        }
    }
}
