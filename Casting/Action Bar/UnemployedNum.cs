using System;

namespace colony_builder.Casting
{
    public class UnemployedNum : Actor
    {
        private int _unemployedNum;
        EmployedVillagers _employedVillagers;

        public UnemployedNum(Point position, EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _unemployedNum = _employedVillagers.GetUnemployed();
            SetText(_unemployedNum.ToString());
            SetPosition(position);
        }

        public override void DoAction()
        {

        }

        public override void Update()
        {
            if (Debug.debug && _unemployedNum != _employedVillagers.GetUnemployed())
            {
                Console.WriteLine("UnemployedNum updated");                    
            }
            _unemployedNum = _employedVillagers.GetUnemployed();
            SetText(_unemployedNum.ToString());
        }
    }
}
