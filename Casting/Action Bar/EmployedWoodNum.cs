using System;

namespace colony_builder.Casting
{
    public class EmployedWoodNum : Actor
    {
        private int _employedWoodNum;
        EmployedVillagers _employedVillagers;

        public EmployedWoodNum(Point position,EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _employedWoodNum = _employedVillagers.GetEmployedOnWood();
            SetText(_employedWoodNum.ToString());
            SetPosition(position);
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
