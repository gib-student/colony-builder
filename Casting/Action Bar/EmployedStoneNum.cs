using System;

namespace colony_builder.Casting
{
    public class EmployedStoneNum : Actor
    {
        private int _employedStoneNum;
        EmployedVillagers _employedVillagers;

        public EmployedStoneNum(Point position,EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _employedStoneNum = _employedVillagers.GetEmployedOnStone();
            SetText(_employedStoneNum.ToString());
            SetPosition(position);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            if (Debug.debug && _employedStoneNum != _employedVillagers.GetEmployedOnStone())
            {
                Console.WriteLine("EmployedStoneNum updated");
            }
            _employedStoneNum = _employedVillagers.GetEmployedOnStone();
            SetText(_employedStoneNum.ToString());
        }
    }
}
