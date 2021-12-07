using System;

namespace colony_builder.Casting
{
    public class UnemployedNum : Actor
    {
        private int _unemployedNum;
        EmployedVillagers _employedVillagers;

        public UnemployedNum(EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _unemployedNum = _employedVillagers.GetUnemployed();
            SetText(_unemployedNum.ToString());
            SetPosition(new Point(
                Constants.UNEMPLOYED_NUMVILLAGERS_X, 
                Constants.UNEMPLOYED_NUMVILLAGERS_Y));
        }

        public override void DoAction()
        {

        }

        public override void Update()
        {
            _unemployedNum = _employedVillagers.GetUnemployed();
            SetText(_unemployedNum.ToString());
        }
    }
}
