using System;

namespace colony_builder.Casting
{
    public class EmployedWoodNum : Actor
    {
        private int _employedWoodNum;
        EmployedVillagers _employedVillagers;

        public EmployedWoodNum(EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _employedWoodNum = _employedVillagers.GetEmployedOnWood();
            SetText(_employedWoodNum.ToString());
            SetPosition(new Point(
                Constants.EMPLOYED_VALUE_X, Constants.WOOD_EMPLOYED_Y));
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            if (Debug.debug && _employedWoodNum != _employedVillagers.GetEmployedOnWood())
            {
                Console.WriteLine("EmployedWoodNum updated");                    
            }
            _employedWoodNum = _employedVillagers.GetEmployedOnWood();
            SetText(_employedWoodNum.ToString());
        }
    }
}
