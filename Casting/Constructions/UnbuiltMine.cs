using System;
using colony_builder.Services;

namespace colony_builder.Casting
{
    public class UnbuiltMine : Actor
    {
        int _mineNum;
        BuildService _buildService;

        public UnbuiltMine(Point position, int mineNum, BuildService buildService)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_MINE_IMG_FILEPATH);
            SetWidth(Constants.MINE_WIDTH);
            SetHeight(Constants.MINE_HEIGHT);
            SetHasActionIfPressed(true);
            _buildService = buildService;

            _mineNum = mineNum;
        }

        public override void DoAction()
        {
            bool canBuild = _buildService.CanBuildMine();
            if (canBuild)
            {
                _buildService.BuildMine(_mineNum);
            }
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
