using System;
using colony_builder.Services;

namespace colony_builder.Casting
{
    public class UnbuiltFarm : Actor
    {
        BuildService _buildService;
        int _farmNum;

        public UnbuiltFarm(Point position, int farmNum, BuildService buildService)
        {
            SetImage(Constants.UNBUILT_FARM_IMG_FILEPATH);
            SetPosition(position);
            SetWidth(Constants.FARM_WIDTH);
            SetHeight(Constants.FARM_HEIGHT);
            SetHasActionIfPressed(true);
            _buildService = buildService;
            _farmNum = farmNum;
        }

        public override void DoAction()
        {
            bool canBuild = _buildService.CanBuildFarm();
            if (canBuild)
            {
                _buildService.BuildFarm(_farmNum);
            }
        }

        public override void Update()
        {
            
        }

        public int GetFarmNum()
        {
            return _farmNum;
        }
    }
}
