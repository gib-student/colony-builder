using System;

namespace colony_builder.Casting
{
    public class EmployedFoodNum : Actor
    {
        private int _employedFoodNum;
        EmployedVillagers _employedVillagers;
        
        public EmployedFoodNum(EmployedVillagers employedVillagers)
        {
            _employedVillagers = employedVillagers;
            _employedFoodNum = employedVillagers.GetEmployedOnFood();
            SetText(_employedFoodNum.ToString());
            SetPosition(new Point(
                Constants.EMPLOYED_VALUE_X, Constants.FOOD_EMPLOYED_Y));
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            if (Debug.debug && _employedFoodNum != _employedVillagers.GetEmployedOnFood())
            {
                Console.WriteLine("EmployedFoodNum updated");                    
            }
            _employedFoodNum = _employedVillagers.GetEmployedOnFood();
            SetText(_employedFoodNum.ToString());
        }
    }
}
