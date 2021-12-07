using System;

namespace colony_builder.Casting
{
    public class EmployedStoneNum : Actor
    {
        private int _employedStoneNum;
        EmployedVillagers _employedVillagers;

        public EmployedStoneNum(EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _employedStoneNum = _employedVillagers.GetEmployedOnStone();
            SetText(_employedStoneNum.ToString());
            SetPosition(new Point(
                Constants.EMPLOYED_VALUE_X, Constants.STONE_EMPLOYED_Y));
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            _employedStoneNum = _employedVillagers.GetEmployedOnStone();
            SetText(_employedStoneNum.ToString());
        }
    }
}
